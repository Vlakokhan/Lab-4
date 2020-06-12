using System;

namespace Lab41
{
     public class Student
        {
            public string Name;
            public string LastName;
            public string Group;
            public int Year;
            public string Adress;
            public string Passport;
            public int Age;
            public string Telephon;
            public int Rating;
    
            public Student(string N, string L, string G, int Y, string A, string P, int Ag, string T, int R)
            {
                Name = N;
                LastName = L;
                Group = G;
                Year = Y;
                Adress = A;
                Passport = P;
                Age = Ag;
                Telephon = T;
                Rating = R;
            }
            public string GetName()
            {
                return Name;
            }
            public string GetLastName()
            {
                return LastName;
            }
            public string GetGroup()
            {
                return Group;
            }
            public int GetYear()
            {
                return Year;
            }
            public string GetAdress()
            {
                return Adress;
            }
            public string GetPassport()
            {
                return Passport;
            }
            public int GetAge()
            {
                return Age;
            }
            public string GetTelephon()
            {
                return Telephon;
            }
            public int GetRating()
            {
                return Rating;
            }
            public string StudentRating(int rating)
            {
                string rating1=" ";
                if (rating >= 90)
                {
                    rating1 = "Вiтаємо вiдмiнника";
                }
    
                if (rating >= 75 & rating < 90)
                {
                    rating1 = "Mожна вчитися краще";
                }
    
                if (rating < 75)
                {
                    rating1 = "Варто більше уваги приділяти навчанню";
                }
    
                return rating1;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student student = new Student("Микола","Шевчук","IТ-14",2019,"вулиця.Личакiвська 78","465895693",23,"067 564 7854",78);
                string Name = student.GetName();
                string LastName = student.GetLastName();
                string Group = student.GetGroup();
                int Year = student.GetYear();
                string Adress = student.GetAdress();
                string Passport = student.GetPassport();
                int Age = student.GetAge();
                string Telephon = student.GetTelephon();
                int Rating = student.GetRating();
                    
                Console.WriteLine("Iм'я: " + Name);
                Console.WriteLine("Прiзвище: " + LastName);
                Console.WriteLine("Група: " + Group);
                Console.WriteLine("Рiк вступу: " + Year);
                Console.WriteLine("Адреса: " + Adress);
                Console.WriteLine("Паспорт: " + Passport );
                Console.WriteLine("Вiк: " + Age);
                Console.WriteLine("Номер телефону: " + Telephon);
                Console.WriteLine("Rating: " + Rating);
                Console.WriteLine(student.StudentRating(Rating));
            }
        }
    } 
