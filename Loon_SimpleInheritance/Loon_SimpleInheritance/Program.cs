using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_SimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sky Loon
            //IT306
            //Exercise 6: Simple Inheritance

            //Instantiate the RegularStudent class
            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Sky Loon",
                Program = "Bachelor of science in information technology",
                Section = "IT306"
                
            };
            regularStudent.BasicInfo(); // Call the method to display Student class
            regularStudent.SectionEnrolled(); // call the method to display RegularStudent class

            //Instantiate the IrregularStudent class
            IrregularStudent irregularStudent = new IrregularStudent
            {
                Name = "Aian Cuyos",
                Program = "Bachelor of science in information technology",
                UnitsEnrolled = 18
            };
            irregularStudent.BasicInfo(); // Call the method to display Student class
            irregularStudent.EnrolledSemUnits(); //  Call the method to display IrregularStudent class

            Console.ReadKey();
        }
    }
}
