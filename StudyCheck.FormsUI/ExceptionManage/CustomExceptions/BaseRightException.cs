using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class BaseRightException:Exception
    {
        public BaseRightException():base()
        {}
        public BaseRightException(string Mesaj):base(Mesaj)
        {}
        public BaseRightException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        public BaseRightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}           
    }
}
