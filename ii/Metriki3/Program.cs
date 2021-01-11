using System;

namespace Metriki3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before optimization
            double income = double.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0.35 * minimalSalary;
            double gradeScholarship = 25 * avarageGrade;

            if (avarageGrade >= 5.5 && income < minimalSalary && socialScholarship >= gradeScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (avarageGrade >= 5.5 && income < minimalSalary && socialScholarship < gradeScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
            }
            else if (avarageGrade > 4.5 && income < minimalSalary)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (avarageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            #endregion

            #region After optimization
            //double income = double.Parse(Console.ReadLine());
            //double avarageGrade = double.Parse(Console.ReadLine());
            //double minimalSalary = double.Parse(Console.ReadLine());

            //double socialScholarship = 0.35 * minimalSalary;
            //double gradesScholarship = 25 * avarageGrade;

            //if (avarageGrade >= 4.5 && income < minimalSalary)
            //{
            //    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            //}
            //else if (avarageGrade >= 5.5)
            //{
            //    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradesScholarship)} BGN");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot get a scholarship!");
            //}
            #endregion
        }
    }
}