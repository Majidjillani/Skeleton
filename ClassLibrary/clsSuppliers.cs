using System;

namespace ClassLibrary
{
    public class clsSuppliers
    {
        public bool IsActive { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
    }
}