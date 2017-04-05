namespace GradeBookProject
{
    public class GradeStatistics
    {
        public float MinGrade = float.MaxValue;
        public float MaxGrade;
        public float AverageGrade;

        public string LetterGrade
        {
            get
            {
                if (AverageGrade >= 90)
                {
                    return "A";
                }
                else
                {
                    if (AverageGrade >= 50)
                    {
                        return "B";
                    }
                    else
                    {
                        return "C";
                    }
                }
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A": result = "Ay du apres :*"; break;
                    case "B":
                    case "C":result = "Dambul"; break;
                    default:
                        result = "Ov es du?"; break;  
                }
                return result;
            }
        }
    }
}