using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class NoDataException : Exception
    {
        public NoDataException():base()
        {}
        public NoDataException(String Mesaj):base(Mesaj)
        {}
        public NoDataException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {}
        protected NoDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {}
    }
}
