using System;
using System.Collections.Generic;
using System.Text;

namespace NewTask
{
    internal class Group
    {

        static int _noProg = 100;
        static int _noDes = 100;
        static int _noSys = 100;
        private Student[] _students;

        NoType _noType { get; set; }    
        public string No;
        public string StrNo { get; }
  
        public Group(NoType type)
        {this._noType = type;

            switch (type)
            {
                case NoType.Programming:
                    _noProg++;
                    StrNo = "P" + _noProg;
                    break;
                case NoType.Design:
                    _noDes++;
                    StrNo = "D" + _noProg;
                    break;
                case NoType.System:
                    _noSys++;
                    StrNo = "S" + _noProg;
                    break;

                default:
                    break;
            }
            _students = new Student[0];
            
            this.No = StrNo;    
        }



        public Student FindStudentByNo(int? no)
        {
            if (no == null)
            {
                throw new ArgNullException("Argument is null");
            }

            foreach (Student student in _students)
            {
                if (student.No == no)
                {
                    return student;
                }

            }
            return null;
        }






     }



    }

