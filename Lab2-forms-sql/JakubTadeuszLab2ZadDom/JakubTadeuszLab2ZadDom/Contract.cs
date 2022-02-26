using System;

namespace JakubTadeuszLab2ZadDom
{
    /// <summary>
    /// Handle button to show all the
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// contract template id
        /// </summary>
        public int contractTemplateId;
        /// <summary>
        /// is deposit required
        /// </summary>
        public bool depositRequired;
        /// <summary>
        /// date of the contract sign
        /// </summary>
        public DateTime startDate;
        /// <summary>
        /// contract length in months
        /// </summary>
        public int contractLength;
        /// <summary>
        /// contract amount
        /// </summary>
        public decimal contractAmount;
        /// <summary>
        /// id of the employee that signed the contract with client
        /// </summary>
        public int employeeId;
        /// <summary>
        /// id of the client that signed the contract
        /// </summary>
        public int clientId;

        public Contract(int contractTemplateId, bool depositRequired, DateTime startDate, int contractLength, decimal contractAmount)
        {
            this.contractTemplateId = contractTemplateId;
            this.depositRequired = depositRequired;
            this.startDate = startDate;
            this.contractLength = contractLength;
            this.contractAmount = contractAmount;
        }

        public Contract(int selectedClientId, int employeeId, int contractTemplateId, DateTime startDate, int contractLength, decimal contractAmount)
        {
            clientId = selectedClientId;
            this.employeeId = employeeId;
            this.contractTemplateId = contractTemplateId;
            this.startDate = startDate;
            this.contractLength = contractLength;
            this.contractAmount = contractAmount;
        }


    }
}