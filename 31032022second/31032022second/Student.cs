using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022second
{
    class Student:Person
    {

        public Student(string name, string surname, byte age, int iqrank, int languagerank) : base(name, surname, age)
        {
            this.IQRank = iqrank;
            this.LanguageRank = languagerank;
        }

        private int _iqrank;
        private int _languagerank;


        public int IQRank { get { return _iqrank; }
            set
            {
                if(Age>6 && Age < 20)
                {
                    _iqrank = value;
                }
            }
        }
        public int LanguageRank { get { return _languagerank; }
            set
            {
                if (Age > 6 && Age < 20)
                {
                    _languagerank = value;
                }
            }
        }

        public void ExamResult(int iqrank, int languagerank)
        {
            int examresult = 0;
            IQRank = iqrank;
            LanguageRank = languagerank;
            if(iqrank>=0&&iqrank<=100)
            {
                if(languagerank>=0&& languagerank <= 100)
                {
                    examresult = iqrank + languagerank;
                    if (examresult > 120)
                    {
                        Console.WriteLine($"Exam result: {examresult}");
                    }
                    else
                    {
                        Console.WriteLine("sinifde qaldiniz!");
                    }
                    
                }
            }
            
        }
       
        
    }
}
