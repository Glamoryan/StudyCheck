using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class AccountInactiveException:Exception
    {
        public AccountInactiveException():base()
        {}
        public AccountInactiveException(String Mesaj) : base(Mesaj)
        {}
        public AccountInactiveException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        public AccountInactiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }
}
