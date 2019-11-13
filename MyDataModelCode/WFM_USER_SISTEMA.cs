using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace WebApplication1.ePx_ECM
{

    public partial class WFM_USER_SISTEMA
    {
        public WFM_USER_SISTEMA(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
