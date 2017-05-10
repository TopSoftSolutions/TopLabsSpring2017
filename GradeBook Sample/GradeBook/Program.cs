using System;
using System.IO;

namespace GradeBookProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            GradeBook gb1 = new GradeBook(5);
            gb1.NameChanged += OnNameChanged;
            gb1.NameChanged += OnNameChanged2;
            try
            {
                Console.WriteLine("Please enter name for gradebook: ");
                gb1.Name = Console.ReadLine();
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine($"{ex.GetType()} Spanir :(");
            }
            catch (GradebookArgumentException ex)
            {
                Console.WriteLine($"{ex.GetType()} Gradebook@ sxal e. level: {ex.MyProperty}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception {ex.GetType()}: {ex.Message}");
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
       
            
            gb1.Type = GradeBookType.PhD;
            gb1.AddGrade(91);
            gb1.AddGrade(89.5f);
            gb1.AddGrade(75);

            gb1.Name = "Petros";

            StreamWriter outFile = File.CreateText("grades.txt");
            DumpGradeBookGrades(gb1, outFile);
            outFile.Close();
            //GradeBook gb2 = new GradeBook(5);
            //gb2.Name = "Mukuchik";
            //gb2.Type = GradeBookType.PhD;
            //gb2.AddGrade(100);
            //gb2.AddGrade(100);
            //gb2.AddGrade(100);
            //gb2.NameChanged += OnNameChanged;
            //gb2.NameChanged += OnNameChanged2;
            //gb2.Name = "Petrosik";

            Console.Read();
        }

        private static void DumpGradeBookGrades(GradeBook gb1, StreamWriter outFile)
        {
            outFile.WriteLine(gb1.Name);
            for (int i = 0; i < gb1.grades.Count; i++)
            {
                outFile.WriteLine($"{i+1}.) {gb1.grades[i]}");
            }
        }

        public static void PrintValue(string variableName, float value)
        {
            //Console.WriteLine(variableName + ": " + value.ToString());
            Console.WriteLine($"{variableName}: {value:F3}");
        }

        public static void PrintValue(string variableName, int value)
        {
            Console.WriteLine("{0}: {1}", variableName, value);
        }

        public static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            GradeBook book = (GradeBook)sender;
            GradeStatistics stats = book.CalcualteStatistics();

            Console.WriteLine("Old: {0}, New: {1}, AverageGrade: {2}", args.OldName, args.NewName, stats.AverageGrade);
        }

        public static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"V2 Old: {args.OldName}, New: {args.NewName}");
        }

    }
}
