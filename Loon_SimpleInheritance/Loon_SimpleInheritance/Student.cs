using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_SimpleInheritance
{
    class Student //Base class
    {
        //Properties for the student class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display student information
        public void BasicInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tStudent Information");
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine($"Name: {Name} \nProgram: {Program}");
        }

    }
    class RegularStudent : Student //Derived class
    {
        //Properties for the RegularStudent class
        public string Section { get; set; }

        //Method to display RegularStudent class
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section Enrolled: {Section}");
        }
    }
    class IrregularStudent : Student //Derives class
    {
        //Properties for the IrregularStudent class
        public int UnitsEnrolled { get; set; }

        //method to display IrregularStudent class
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Units enrolled: {UnitsEnrolled}");
        }

    }
  
}
