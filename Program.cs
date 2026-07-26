using System;
using System.Runtime.CompilerServices;
namespace StudentAdmissionManagement
{
    class student
    {
        public int AdmissionId;
        public string StudentName;
        public int Age;
        public string Course;
        public int Semester;
        public int Fees;

        public bool ScholarshipEligible;
        public double ScholarshipRate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine("=======================================");
            Console.WriteLine(" STUDENT ADMISSION MANAGEMENT SYSTEM");
            Console.WriteLine("=======================================");

            Console.WriteLine();

            Console.WriteLine("Enter AdmissionId : ");
            s1.AdmissionId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Name : ");
            s1.StudentName = Console.ReadLine();

            Console.WriteLine("Enter yout Age : ");
           
 s1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Course name : ");
            s1.Course = Console.ReadLine();

            Console.WriteLine("Enter you Semester : ");
            s1.Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fees paid : ");
            s1.Fees = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Eligible for Scholarship or not: ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                s1.ScholarshipEligible = true;
                s1.ScholarshipRate = s1.Fees * 0.10;
            }
            else
            {
                s1.ScholarshipEligible = false;
                s1.ScholarshipRate = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Student Details saved successfully.");

            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("        STUDENT DETAILS");
            Console.WriteLine("=======================================");

            Console.WriteLine("Admission ID : " + s1.AdmissionId);
            Console.WriteLine("Student Name : " + s1.StudentName);
            Console.WriteLine("Age : " + s1.Age);
            Console.WriteLine("Course Name: " + s1.Course);
            Console.WriteLine("Semester : " + s1.Semester);
            Console.WriteLine("Fees : " + s1.Fees);
            Console.WriteLine("Scholarship Eligible : " + s1.ScholarshipEligible);
            Console.WriteLine("Scholarship Amount   : " + s1.ScholarshipRate);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

    }

}
