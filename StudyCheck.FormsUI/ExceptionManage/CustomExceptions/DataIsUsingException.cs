using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class DataIsUsingException:Exception
    {
        public DataIsUsingException():base()
        {}
        public DataIsUsingException(string Mesaj):base(Mesaj)
        {}
        public DataIsUsingException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        public DataIsUsingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }
}
