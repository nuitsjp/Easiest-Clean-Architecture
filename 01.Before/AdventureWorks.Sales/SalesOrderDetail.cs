using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorks.Sales.Domain
{
    [Table("SalesOrderDetail", Schema = "Sales")]
    public class SalesOrderDetail
    {
        [Key]
        public virtual int SalesOrderID { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int SalesOrderDetailID { get; set; }
        public virtual string CarrierTrackingNumber { get; set; }
        public virtual short OrderQty { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int SpecialOfferID { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal UnitPriceDiscount { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public virtual decimal LineTotal { get; set; }
        public virtual Guid rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}