using System;

namespace GradeBookProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook gb1 = new GradeBook(5);
            gb1.Name = "Mukuch";
            gb1.Type = GradeBookType.PhD;
            gb1.AddGrade(91);
            gb1.AddGrade(89.5f);
            gb1.AddGrade(75);
            gb1.NameChanged = onNameChange;
            gb1.NameChanged += onNameChange2;
            gb1.Name = "Petros";

            GradeStatistics stats = gb1.CalcualteStatistics();
         //   PrintValue("Average Grade", stats.AverageGrade);
         //   PrintValue(nameof(stats.MaxGrade), stats.MaxGrade);
           

            gb1.Name = null;

            Console.WriteLine(gb1.Name.ToUpper());
            Console.Read();
        }

        public static void PrintValue(string variableName, float value)
        {
            //Console.WriteLine(variableName + ": " + value.ToString());
            Console.WriteLine($"{variableName}: {value:F3}");
        }

        public static void onNameChange(string existingName, string newName)
        {
            Console.WriteLine("Old: {0}, New: {1}", existingName, newName);
        }
        public static void onNameChange2(string existingName, string newName)
        {
            Console.WriteLine($"V2 Old: {existingName}, New: {newName}");
        }

    }
}
