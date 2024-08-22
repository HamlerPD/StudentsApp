using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentsApp
{
    public class GuidedProject
    {
        public GuidedProject() 
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // Student names
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
            int[] studentScores = new int[10]; 

            foreach (string name in studentNames)
            {
                string currentStudent = name;
                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;
                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;
                else if (currentStudent == "Emma")
                    studentScores = emmaScores;
                else if (currentStudent == "Logan")
                    studentScores = loganScores;


                    int sumAssignmentScores = 0;
                    decimal currentStudentGrade = 0;

                    foreach (int score in studentScores)
                    {
                        // add the exam score to the sum
                        sumAssignmentScores += score;
                    }

                    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
                    string currentStudentLetterGrade = "";

                

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";
                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";
                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";
                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";
                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";
                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";
                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";
                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";
                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";
                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";
                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";
                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";
                else
                    currentStudentLetterGrade = "C";


                Console.WriteLine("Student\t\tGrade\n");
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");


            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();


        }
    }
}
