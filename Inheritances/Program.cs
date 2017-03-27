using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Student
    {
        public string name;
        public int rollnumber;

           public void getstudent()
       {
           Console.WriteLine("The Name of Student is " + name);
          Console.WriteLine("The rollnumber of Student is " +rollnumber);

        }

    }

    class Graded:Student
    {
        public int grade;
        public void gradeinfo()
        {
            Console.WriteLine("The Grade of Student is " + grade);
        }
    }


    class school
    {
        static void Main()
        {
            Graded g1 = new Graded();
            Graded g2 = new Graded();
           g1.name = "Aniket";
            g1.rollnumber = 3434;
            g2.grade = 23;
            g1.getstudent();
            g2.gradeinfo();
               Console.ReadKey();
        }


    }



}
