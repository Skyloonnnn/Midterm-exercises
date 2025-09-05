using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_InheritanceWithConstructor
{
    class Student //Base class
    {
        //Declare fields for student
        public string name;
        public string program;

        //Parameterized Constructor
        public Student(string studentName, string studentProgram)
        {
            name = studentName;
            program = studentProgram;
        }

        //Method to display student info
        public void BasicInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tStudent Information");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nStudent Name: {name} \nProgram: {program}");
        }
    }

    class RegularStudent : Student // derived class
    {
        //Declare fields for regular student
        public string section;

        //Parameterized Constructor
        public RegularStudent(string studentName, string studentProgram, string studentSection) : base(studentName, studentProgram)
        {
            section = studentSection;
        }

        //Method to display Regular Student info
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine($"Section: {section}");
        }
    }

    class IrregularStudent : Student //derived class
    {
        //Declare fields for Irregular Student 
        public int units;

        //Parameterized Constructor
        public IrregularStudent(string studentName, string studentProgram, int unitsEnrolled) : base(studentName, studentProgram)
        {
            units = unitsEnrolled;
        }

        //Method to display Irregular Student info
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"Enrolled Units: {units}");
        }
    }
}
