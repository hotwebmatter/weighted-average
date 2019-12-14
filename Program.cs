using System;
using static System.Console;

namespace weighted_average
{
    class Program
    {
        const double HOMEWORK = .1,
                     PROJECTS = .35,
                     QUIZZES = .1,
                     EXAMS = .3,
                     FINAL = .15;
        static void Main(string[] args)
        {
            double homework = 97,
                   weightedHomework = homework * HOMEWORK / 100,
                   projects = 82,
                   weightedProjects = projects * PROJECTS / 100,
                   quizzes = 60,
                   weightedQuizzes = quizzes * QUIZZES / 100,
                   exams = 75,
                   weightedExams = exams * EXAMS / 100,
                   finalExam = 80,
                   weightedFinal = finalExam * FINAL / 100;
            WriteLine("{0, 12} {1, 8} {2, 8}", "GRADE TYPE", "WEIGHT", "VALUE");
            WriteLine("{0, 12} {1, 8:P0} {2, 8:P2}", "Homework:", HOMEWORK, weightedHomework);
            WriteLine("{0, 12} {1, 8:P0} {2, 8:P2}", "Projects:", PROJECTS, weightedProjects);
            WriteLine("{0, 12} {1, 8:P0} {2, 8:P2}", "Quizzes:", QUIZZES, weightedQuizzes);
            WriteLine("{0, 12} {1, 8:P0} {2, 8:P2}", "Exams:", EXAMS, weightedExams);
            WriteLine("{0, 12} {1, 8:P0} {2, 8:P2}", "Final Exam:", FINAL, weightedFinal);
            WriteLine("{0, 12} {1, 8} {2, 8:P2}",
                      "Final Grade:",
                      "",
                      weightedHomework + weightedProjects + weightedQuizzes + weightedExams + weightedFinal);
        }
    }
}
