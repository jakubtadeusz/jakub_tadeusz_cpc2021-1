namespace JakubTadeuszLab2ZadDom
{
    /// <summary>
    /// Stores info about the contract template
    /// </summary>
    public class Document
    {
        public Document(string contractName)
        {
            this.ContractName = contractName;
        }

        /// <summary>
        /// name of the contract
        /// </summary>
        public string ContractName { get; }
        /// <summary>
        /// percentage monthly interest
        /// </summary>
        public decimal ContractMonthlyPercentageInterest { get; internal set; }
        /// <summary>
        /// minimum contract duration in months
        /// </summary>
        public int ContractMinimumMonthDuration { get; internal set; }
        /// <summary>
        /// maximum contract duration in months
        /// </summary>
        public int ContractMaximumMonthDuration { get; internal set; }
        /// <summary>
        /// if deposit is required
        /// </summary>
        public bool DepositRequired { get; internal set; }
        /// <summary>
        /// monthly costs of the contract operation
        /// </summary>
        public decimal ContractMonthlyOperatingCost { get; internal set; }
        /// <summary>
        /// contract document file path
        /// </summary>
        public string ContractDocumentLocation { get; internal set; }
    }
}