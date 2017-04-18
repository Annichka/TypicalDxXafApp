﻿using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace TypicalDXeXpressAppProject_DoSo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Invoice : XPLiteObjectBase
    {
        public Invoice(Session session) : base(session) { }
        // mater 
        //khjgj
        [Association]
        public Customer Customer { get; set; }
    }
}