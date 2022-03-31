using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask
{
    internal class ArgNullException:Exception
    {
        public ArgNullException(string msg):base(msg)
        {

        }
    }
}
