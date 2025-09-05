using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sky Loon
            //IT306
            //Exercise 7:Simple Inheritance with Constructor

              
            //Instantian object for Regular Student class
            RegularStudent regularStudent = new RegularStudent("Sky Loon", "Bachelor of science in information technology", "IT306");
            //Call the method to display Regular student info
            regularStudent.SectionEnrolled();

            //Instantian object for Irreegular Student class
            IrregularStudent irregularStudent = new IrregularStudent("Aian Cuyos", "Bachelor of science in information technology", 18);
            //Call the method to display Irregular Student info
            irregularStudent.EnrolledSemUnits();

            Console.ReadKey();
        }
    }
}
