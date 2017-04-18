using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace TypicalDXeXpressAppProject_DoSo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class ServiceType : XPLiteObjectBase
    {

        // hotfix N3
        public ServiceType(Session session) : base(session) { }

        public string ServiceName { get; set; }
        public decimal DefaultRate { get; set; }
    }
}