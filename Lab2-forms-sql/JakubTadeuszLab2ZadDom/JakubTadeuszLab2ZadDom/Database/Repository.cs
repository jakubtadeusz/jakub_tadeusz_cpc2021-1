using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JakubTadeuszLab2ZadDom.Database
{
    class Repository
    {
        /// <summary>
        /// Database connection
        /// </summary>
        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// return id of the user with given login and password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int Login(string login, string password)
        {
            string query = "SELECT UserId FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";

            connection.Open();

            SqlCommand comm = new SqlCommand(query, connection);
            int userId; 
            try { 
                userId = (int)comm.ExecuteScalar();
            }
            catch {
                userId = -1;
            }
            connection.Close();

            return userId;
        }

        /// <summary>
        /// returns data from table with given (string) name
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        internal DataTable GetAllFromTable(string tableName)
        {
            string query = "SELECT * FROM " + tableName;
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// return string with client info fiven (int) client id
        /// </summary>
        /// <param name="selectedClientId"></param>
        /// <returns></returns>
        internal string GetClientInfo(int selectedClientId)
        {
            string query = "SELECT FirstName, LastName, PESEL FROM Clients WHERE Id=" + selectedClientId.ToString();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            reader.Read();
            string clientInfo = reader["FirstName"].ToString().Trim(' ') + " " + reader["LastName"].ToString().Trim(' ') +
                "\nPESEL: " +reader["PESEL"].ToString().Trim(' ');
            connection.Close();
            return clientInfo;
        }

        /// <summary>
        /// edit client in the database
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="PESEL"></param>
        /// <param name="street"></param>
        /// <param name="flatNumber"></param>
        /// <param name="city"></param>
        /// <param name="postalCode"></param>
        internal void EditClient(int clientId, string firstName, string lastName, long PESEL, string street, string flatNumber, string city, int postalCode)
        {
            connection.Close();
            string query = "UPDATE Clients " +
                "SET FirstName = '" + firstName+"'," +
                "LastName = '" +lastName +"'," +
                "PESEL = " + PESEL.ToString()+ ", Street = '" + street + "'," +
                "FlatNumber = '" + flatNumber + "'," +
                "City = '"+ city +"', " +
                "PostalCode = " + postalCode.ToString() +" WHERE Id = " + clientId.ToString();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// return DataTable with contacts with client given (int) id
        /// </summary>
        /// <param name="contractId"></param>
        /// <param name="selectedClientId"></param>
        /// <returns></returns>
        internal DataTable GetClientContacts(int contractId, int selectedClientId)
        {
            string query = "SELECT Date, ContactTypes.ContactName, EmployeeId FROM ClientContactHistory LEFT JOIN ContactTypes ON ContactTypes.Id = ClientContactHistory.ContactType WHERE ClientId = " + selectedClientId.ToString() +" AND ContractId = " + contractId.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Adds contact with client
        /// </summary>
        /// <param name="contractId"></param>
        /// <param name="selectedClientId"></param>
        /// <param name="userId"></param>
        /// <param name="contactType"></param>
        internal void AddClientContact(int contractId, int selectedClientId, int userId, int contactType)
        {
            string query = "INSERT INTO ClientContactHistory(Date, ContactType, EmployeeId, ClientId, ContractId) VALUES('" +
               DateTime.Now.ToString() + "', " + contactType.ToString() + ", " + userId.ToString() +", " + selectedClientId.ToString() + ", "+
               contractId.ToString()+ ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Add operation to the contract etc. payment
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="selectedClientId"></param>
        /// <param name="contractId"></param>
        /// <param name="paidValue"></param>
        internal void AddContractOperation(int employeeId, int selectedClientId, int contractId, decimal paidValue)
        {
            string query = "INSERT INTO ContractOperationS(ContractId, EmployeeId, ClientId, PaidAmount, Date) VALUES(" +
                contractId.ToString() + ", " + employeeId.ToString() + ", " + selectedClientId.ToString() + ", " + paidValue.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ", ' " + DateTime.Now.ToString() + "')";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            AddClientContact(contractId, selectedClientId, employeeId, 4);
        }

        /// <summary>
        /// Returns DataTable with client deposits
        /// </summary>
        /// <param name="selectedClientId"></param>
        /// <returns></returns>
        internal DataTable GetClientDeposits(int selectedClientId)
        {
            string query = "SELECT Deposits.DepositName AS Nazwa, Deposits.DepositValue AS Wartość FROM Deposits WHERE Deposits.DepositOwner = " + selectedClientId.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Returns DataTable of client active contracts
        /// </summary>
        /// <param name="selectedClientId"></param>
        /// <returns></returns>
        internal DataTable GetClientActiveContracts(int selectedClientId)
        {
            string query = "SELECT Contracts.Id, ContractTemplates.ContractName AS Umowa," +
                " SUM(ContractOperations.PaidAmount) AS Kwota, Deposits.DepositName AS Depozyt FROM Contracts" +
                " LEFT JOIN ContractOperations ON Contracts.Id = ContractOperations.ContractId " +
                "LEFT JOIN ContractTemplates ON Contracts.ContractTemplateId = ContractTemplates.Id" +
                " LEFT JOIN Deposits ON Deposits.Id = Contracts.DepositId WHERE Contracts.Id in" +
                " (SELECT ContractOperations.ContractId FROM ContractOperations WHERE ContractOperations.ClientId = " + selectedClientId.ToString() + " GROUP BY ContractOperations.ContractId HAVING SUM(ContractOperations.PaidAmount) < 0) " +
                "GROUP BY Contracts.Id, ContractTemplates.ContractName, Deposits.DepositName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Adds client deposit
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="depositName"></param>
        /// <param name="depositValue"></param>
        /// <returns></returns>
        internal int AddDeposit(int clientId, string depositName, decimal depositValue)
        {
            string query = "INSERT INTO Deposits(DepositName, DepositValue, DepositOwner) OUTPUT INSERTED.ID VALUES('" + depositName + "', " + depositValue.ToString(CultureInfo.CreateSpecificCulture("en-GB"))
                + ", " + clientId + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            int depositId = (int)sqlCommand.ExecuteScalar();
            connection.Close();
            return depositId;
        }

        /// <summary>
        /// Adds new contract
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        internal int AddContract(Contract contract)
        {
            //Dodaj nową umowę
            string query = "INSERT INTO Contracts(ContractTemplateId, EmployeeId, ClientId, DateStart, MonthLength, ContractAmount)" +
                "OUTPUT INSERTED.ID" +
                " VALUES (" + contract.contractTemplateId.ToString() + ", " + contract.employeeId.ToString() + "," +
    contract.clientId.ToString() + ", '" + contract.startDate.ToString() + "', " + contract.contractLength.ToString() +"," + contract.contractAmount.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            int insertedContractId = (int)sqlCommand.ExecuteScalar();
           
            query = "INSERT INTO ClientContactHistory(Date, ContactType, EmployeeId, ClientId, ContractId) VALUES('" +DateTime.Now.ToString() +
                "', 4, " + contract.employeeId.ToString() + ", " + contract.clientId.ToString() + ", " + insertedContractId.ToString() + ")";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();

            query = "INSERT INTO ContractOperations(ContractId, EmployeeId, ClientId, Date, PaidAmount) VALUES (" + insertedContractId + ", " + contract.employeeId.ToString() + ", " + contract.clientId.ToString() + ", '" +
             DateTime.Now.ToString() + "', " + (-contract.contractAmount).ToString(CultureInfo.CreateSpecificCulture("en-GB")) +")";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();

            connection.Close();
            return insertedContractId;
        }

        /// <summary>
        /// Adds new contract with deposit
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="depositName"></param>
        /// <param name="depositValue"></param>
        /// <returns></returns>
        internal int AddContractWithDeposit(Contract contract, string depositName, Decimal depositValue)
        {
            int depositId = AddDeposit(contract.clientId, depositName, depositValue);

            string query = "INSERT INTO Contracts(ContractTemplateId, EmployeeId, ClientId, DateStart, MonthLength, ContractAmount, DepositId)" +
                "OUTPUT INSERTED.ID" +
                " VALUES (" + contract.contractTemplateId.ToString() + ", " + contract.employeeId.ToString() + "," +
    contract.clientId.ToString() + ", '" + contract.startDate.ToString() + "', " + contract.contractLength.ToString() + "," + contract.contractAmount.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + "," +
     depositId.ToString() + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            int insertedContractId = (int)sqlCommand.ExecuteScalar();

            query = "INSERT INTO ClientContactHistory(Date, ContactType, EmployeeId, ClientId, ContractId) VALUES('" + DateTime.Now.ToString() +
                "', 5, " + contract.employeeId.ToString() + ", " + contract.clientId.ToString() + ", " + insertedContractId.ToString() + ")";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();

            query = "INSERT INTO ContractOperations(ContractId, EmployeeId, ClientId, Date, PaidAmount, DepositId) VALUES (" + insertedContractId + ", " + contract.employeeId.ToString() + ", " + contract.clientId.ToString() + ", '" +
             DateTime.Now.ToString() + "', " + (-contract.contractAmount).ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ", " + depositId.ToString() + ")";
            sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();

            connection.Close();
            return insertedContractId;
        }

        /// <summary>
        /// Add first and last name of the user given (int) user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        internal string GetUserInfo(int userId)
        {
            string query = "SELECT FirstName, LastName FROM Employees WHERE Id=" + userId.ToString();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            string userInfo = reader["FirstName"].ToString().Trim(' ') + " " + reader["LastName"].ToString().Trim(' ');
            connection.Close();
            return userInfo;
        }

        /// <summary>
        /// Adds new client
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="PESEL"></param>
        /// <param name="street"></param>
        /// <param name="flatNumber"></param>
        /// <param name="city"></param>
        /// <param name="postalCode"></param>
        internal void AddClient(string name, string lastName, BigInteger PESEL, string street, string flatNumber, string city, int postalCode)
        {
            string query = "INSERT INTO Clients(FirstName, LastName, PESEL, Street, FlatNumber, City, PostalCode) VALUES('" +
                name+"', '"+ lastName + "', " + PESEL.ToString() + ", '" + street+"', '" + flatNumber +"', '" + city+ "', " + postalCode + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Adds new document
        /// </summary>
        /// <param name="document"></param>
        internal void AddDocument(Document document)
        {
            string query = "INSERT INTO " +
                "ContractTemplates(ContractName, " +
                "ContractMonthlyPercentageInterest, ContractMonthlyOperatingCost, DepositRequired," +
                "ContractMinimumMonthDuration, ContractMaximumMonthDuration," +
                "ContractDocumentLocation) " +
                "VALUES('" + document.ContractName + "', " 
                + document.ContractMonthlyPercentageInterest.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ", " +document.ContractMonthlyOperatingCost.ToString(CultureInfo.CreateSpecificCulture("en-GB")) + ", '" + document.DepositRequired.ToString() +
                "', " + document.ContractMinimumMonthDuration + ", " + document.ContractMaximumMonthDuration + ", " +
                "'" + document.ContractDocumentLocation.ToString() + "')";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Returns all of the operations
        /// </summary>
        /// <returns></returns>
        internal DataTable GetOperations()
        {
            string query = "SELECT Op.Date AS 'Data', ContractInfo.Name AS 'Typ operacji', Op.PaidAmount AS 'Kwota', Employees.FirstName AS 'Imię pracownika', Employees.LastName AS 'Nazwisko pracownika', Clients.FirstName as 'Imię klienta', Clients.LastName AS 'Nazwisko klienta', Clients.PESEL AS 'PESEL klienta' FROM ContractOperations Op LEFT JOIN(SELECT Contracts.Id, ContractTemplates.ContractName AS 'Name' FROM Contracts JOIN ContractTemplates ON Contracts.ContractTemplateId = ContractTemplates.Id) AS ContractInfo ON ContractInfo.Id = Op.ContractId LEFT JOIN Employees ON Op.EmployeeId = Employees.Id LEFT JOIN Clients ON Op.ClientId = Clients.Id ORDER BY Op.Date DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Returns all of the contracts
        /// </summary>
        /// <returns></returns>
        internal DataTable GetContracts()
        {
            string query = "SELECT ContractTemplates.ContractName AS 'Typ umowy', Contracts.ContractAmount AS 'Kwota', Contracts.DateStart AS 'Rozpoczęcie', Contracts.MonthLength AS 'Długość umowy', Deposits.DepositName AS 'Zastawiono',  Employees.FirstName AS 'Imię pracownika', Employees.LastName AS 'Nazwisko pracownika', Clients.FirstName AS 'Imię klienta', Clients.LastName AS 'Nazwisko klienta', Clients.PESEL AS 'Numer PESEL' FROM Contracts LEFT JOIN ContractTemplates ON ContractTemplates.Id = Contracts.ContractTemplateId LEFT JOIN Deposits ON DepositId = Deposits.Id LEFT JOIN Employees ON EmployeeId = Employees.Id LEFT JOIN Clients ON ClientId = Clients.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Returns all clients
        /// </summary>
        /// <returns></returns>
        internal DataTable GetClients()
        {
            string query = "SELECT * FROM Clients";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Deposits cash to the cash register
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="userId"></param>
        internal void DepositCash(decimal amount, int userId)
        {
            //ContractId = 1 is cash deposit
            string query = "INSERT INTO ContractOperations(ContractId, EmployeeId, Date, PaidAmount) VALUES (1, " + userId.ToString() + ", '"  + 
                DateTime.Now.ToString() +"', " + amount.ToString() + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Withdraw cash from the cash register
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="userId"></param>
        internal void PayoutCash(decimal amount, int userId)
        {
            //ContractId = 3 is cash withdrawal
            string query = "INSERT INTO ContractOperations(ContractId, EmployeeId, Date, PaidAmount) VALUES (3, " + userId.ToString() + ", '" +
                DateTime.Now.ToString() + "', -" + amount.ToString() + ")";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Return loan template
        /// </summary>
        /// <returns></returns>
        internal DataTable GetDocuments()
        {
            string query = "SELECT Id, ContractName as 'Nazwa dokumentu', ContractMonthlyPercentageInterest AS 'Miesięczne odsetki'," +
                "ContractMonthlyOperatingCost AS 'Koszt operacyjny', ContractMinimumMonthDuration AS 'Minimalna długość'," +
                "ContractMaximumMonthDuration AS 'Maksymalna długość', DepositRequired AS 'Wymagany depozyt', ContractDocumentLocation AS 'Dokument do druku' FROM ContractTemplates";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Return amount in the cash register
        /// </summary>
        /// <returns></returns>
        internal Decimal GetCachRegisterSum()
        {
            Decimal cashRegisterAmount = 0;
            string query = "SELECT SUM(PaidAmount) FROM ContractOperations";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            try
            {
                cashRegisterAmount += (Decimal)sqlCommand.ExecuteScalar();
            }
            catch { }
            connection.Close();
            return cashRegisterAmount;
        }

        /// <summary>
        /// Return all of the deposits
        /// </summary>
        /// <returns></returns>
        internal DataTable GetDeposits()
        {
            string query = "SELECT * FROM Deposits";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Return SqlDataReader with client info
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        internal SqlDataReader GetClient(int clientId)
        {
            string query = "SELECT * FROM Clients WHERE Id = " + clientId.ToString();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            return reader;
        }
    }
}
