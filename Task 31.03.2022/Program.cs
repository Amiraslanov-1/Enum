using System;

namespace NewTask
{
    internal class Program
    {



        public static void Main()
        {

            Group group = new Group(NoType.Programming);
            Group group1 = new Group(NoType.Programming);
            Group group2 = new Group(NoType.Design);
            Group group3 = new Group(NoType.System);

           
            Console.WriteLine(group1.StrNo);
            
        }



    }
    }

