﻿using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace TypicalDXeXpressAppProject_DoSo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Invoice : XPLiteObjectBase
    {
        public Invoice(Session session) : base(session) { }
        // mater 
        //khjgjrfgfdgfd
        [Association]dfgfd
        public Customer Customer { get; dsfdsfdsset; }
    }
}