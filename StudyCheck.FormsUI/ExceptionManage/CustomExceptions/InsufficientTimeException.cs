using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudyCheck.FormsUI.ExceptionManage.CustomExceptions
{
    class InsufficientTimeException:Exception
    {
        public InsufficientTimeException():base()
        {}
        public InsufficientTimeException(String Mesaj) : base(Mesaj)
        {

        }
        public InsufficientTimeException(String Mesaj, Exception innerException) : base(Mesaj, innerException)
        {

        }
        public InsufficientTimeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
