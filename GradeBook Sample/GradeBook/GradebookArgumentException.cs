using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookProject
{
    public class GradebookArgumentException : ArgumentException
    {
        public int MyProperty { get; set; }

        public GradebookArgumentException(string message, int level): base(message)
        {
            this.MyProperty = level;
        }

    }
}
