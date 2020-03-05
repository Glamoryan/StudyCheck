using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class InvalidAccountException:Exception
    {
        public InvalidAccountException():base()
        {}
        public InvalidAccountException(String Mesaj) : base(Mesaj)
        {}
        public InvalidAccountException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        public InvalidAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }
}
