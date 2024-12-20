using System;


namespace Lab_2
{

public class Program
{
    
    public static void Main(string[] args)
    {
            Console.WriteLine("Enter choise of program :");
            int n= Convert.ToInt32(Console.ReadLine());

            switch (n) { 
                case 1:
                        Candidate candidate = new Candidate();
                        candidate.GetCandidateDetails();
                         candidate.DisplayCandidateDetails();
                break;

                case 2:
                    Staff[] staffArray = new Staff[3];
                    for (int i = 0; i < staffArray.Length; i++) 
                    {
                        Console.WriteLine($"\nEnter details for Staff {i + 1}:"); 
                        staffArray[i] = new Staff(); 
                        staffArray[i].GetStaffDetails();
                    }
                    Console.WriteLine("\nDetails of HODs:");
                    for (int j = 0; j < staffArray.Length; j++) 
                    {
                        staffArray[j].DisplayHODDetails(); 
                    }
                    break;
                case 3:
                    Bank_Account account = new Bank_Account();
                    account.GetAccountDetails();
                    account.DisplayAccountDetails();
                    break;
                case 4:
                    
                        Console.Write("Enter Enrollment No: ");
                        int enrollmentNo = int.Parse(Console.ReadLine());
                        Console.Write("Enter Student Name: ");
                        string studentName = Console.ReadLine();
                        Console.Write("Enter Semester: ");
                        int semester = int.Parse(Console.ReadLine());
                        Console.Write("Enter CPI: ");
                        float cpi = float.Parse(Console.ReadLine());
                        Console.Write("Enter SPI: ");
                        float spi = float.Parse(Console.ReadLine());
                        Student student = new Student(enrollmentNo, studentName, semester, cpi, spi);
                        student.DisplayStudentDetails();
                        break;
                    
                case 5:
                    
                        Console.Write("Enter the length of the rectangle: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter the width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle(length, width);

                        double area = rectangle.CalculateArea();
                        Console.WriteLine($"The area of the rectangle is: {area}");
                        break; 
                    
                case 6:
                    Interest interest = new Interest();
                    interest.GetAccountDetails();
                    interest.DisplayTotalInterest();
                    break;
                case 7:
                    Console.WriteLine("Enter Basic Salary:");
                    double basic = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter TA:");
                    double ta = Convert.ToDouble(Console.ReadLine());

                    Salary salary = new Salary(basic, ta);
                    salary.DisplaySalary();
                    break;
                case 8:
                    Console.WriteLine("Enter the first distance:");
                    double d1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second distance:");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    Distance distance = new Distance(d1, d2);
                    
                    distance.CalculateAddition();
                    distance.DisplayAddition();

                   
                    break;
            }
        }
}

}