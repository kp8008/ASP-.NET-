using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        public int Enrollment_No { get; set; }
        public string Student_Name { get; set; }
        public int Semester { get; set; }
        public float CPI { get; set; }
        public float SPI { get; set; }
        public Student(int enrollmentNo, string studentName, int semester, float cpi, float spi)
        {
            Enrollment_No = enrollmentNo; 
            Student_Name = studentName; 
            Semester = semester;
            CPI = cpi; 
            SPI = spi;

        }
        public void DisplayStudentDetails()
        { 
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Enrollment No: {Enrollment_No}"); 
            Console.WriteLine($"Student Name: {Student_Name}"); 
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"CPI: {CPI}"); 
            Console.WriteLine($"SPI: {SPI}");
        }
    }
}
