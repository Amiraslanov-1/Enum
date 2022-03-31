using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask
{
    internal class Student
    {
        public Student()
        {
            _no++;

        }
        static int _no;
        public int No { get { return _no; } }
        public string FullName { get; set; }
    }
}
