using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.Core.Aspects.Postsharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperation:OnMethodBoundaryAspect
    {
        public string Roller { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roller.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < Roller.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                    isAuthorized = true;
            }
            if (!isAuthorized)
                throw new SecurityException("Yetkiniz yok!");            
            
        }
    }
}
