﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookProject
{
    public class GradeBook
    {
        public event NameChangedDelegate NameChanged;
        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new GradebookArgumentException("The provide value for property is invalid.", 100);
                }

                _name = value;
                NameChangedEventArgs args = new NameChangedEventArgs();
                args.OldName = _name;
                args.NewName = value;
                NameChanged(this, args);
            }
        }

        public GradeBookType Type = GradeBookType.Bachelor;
        public static int MaximumGrade = 100;
        public static int MinimumGrade = 0;

        public List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeBook(int capacity)
        {
            grades = new List<float>(capacity);
        }

        public void AddGrade(float grade)
        {
            if (grade < 0)
            {
                return;
            }
            grades.Add(grade);
        }

        public GradeStatistics CalcualteStatistics()
        {
            GradeStatistics result = new GradeStatistics();
            float sum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                result.MaxGrade = Math.Max(grades[i], result.MaxGrade);
                result.MinGrade = Math.Min(grades[i], result.MinGrade);
                sum += grades[i];
            }
            result.AverageGrade = sum / grades.Count;

            return result;
        }
    }
}
