using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    public class DataAlreadyExistsException:Exception
    {
        public DataAlreadyExistsException():base()
        {}
        public DataAlreadyExistsException(String Mesaj):base(Mesaj)
        {}
        public DataAlreadyExistsException(String Mesaj,Exception innerException):base(Mesaj,innerException)
        {}
        protected DataAlreadyExistsException(SerializationInfo info,StreamingContext context):base(info,context)
        {}
    }
}
