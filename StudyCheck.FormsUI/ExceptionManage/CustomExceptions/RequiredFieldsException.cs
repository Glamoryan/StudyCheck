using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class RequiredFieldsException:Exception
    {
        public RequiredFieldsException():base()
        {}
        public RequiredFieldsException(String Mesaj):base(Mesaj)
        {}
        public RequiredFieldsException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        protected RequiredFieldsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }
}
