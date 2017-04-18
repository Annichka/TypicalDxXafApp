using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using CSharpFunctionalExtensions;
using DevExpress.Data.ODataLinq.Helpers;


namespace TypicalDXeXpressAppProject_DoSo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class StockBalance : XPLiteObjectBase
    { 
        // hotfix N1 
        // hotfix N2
       
        public StockBalance(Session session) : base(session) {}
        // Developement branch

            //dev 22222
        [Association]fdgfdgdfg
        public StockItem StockItem { get; set; }

        [Association]
        public Customer Customer { get; set; }

        public decimal Amount { get; set; }

    }
}