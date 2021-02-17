using System;

namespace MidExams
{
    class BonusSystem
    {
        static void Main(string[] args)
        {
            int countStudent = int.Parse(Console.ReadLine());//So mush Loops to check each student
            int countLectures = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());

            double maxResultStudent = 0;
            int currStudAttendances = 0;

            for (int i = 0; i < countStudent; i++)
            {                
                int studentAttendances = int.Parse(Console.ReadLine());

                double currStudentResult = (double)studentAttendances / 
                    countLectures * (5 + addBonus);

                if (currStudentResult > maxResultStudent)
                {
                    maxResultStudent = currStudentResult;
                    currStudAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxResultStudent)}.");
            Console.WriteLine($"The student has attended {currStudAttendances} lectures.");
        }
    }
}
