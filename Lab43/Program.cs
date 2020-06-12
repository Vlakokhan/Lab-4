 
    using System;
    using System.IO;
    
namespace Lab43
    {
        public class JCity
        {
            public string name;
            public string adress;
            private string LastName;
            private int houses;
            private string district;
    
            public void Add()
            {
                JCity a = new JCity();
                Console.WriteLine("Назва");
                a.name=Console.ReadLine();
                while (string.IsNullOrEmpty(a.name))
                {
                    Console.WriteLine("Введiть назву:");
                    a.name=Console.ReadLine();
                }
                Console.WriteLine("Адреса");
                a.adress = Console.ReadLine();
                while (string.IsNullOrEmpty(a.adress))
                {
                    Console.WriteLine("Введiть адресу:");
                    a.adress=Console.ReadLine();
                }
                Console.WriteLine("Прiзвище начальника");
                a.LastName= Console.ReadLine();
                while (string.IsNullOrEmpty(a.LastName))
                {
                    Console.WriteLine("Введiть прiзвище начальника:");
                    a.LastName=Console.ReadLine();
                }
                Console.WriteLine("Кiлькiсть пiдзвiтнiх будинкiв");
                a.houses= Int32.Parse(Console.ReadLine());
                Console.WriteLine("Район мiста");
                a.district=Console.ReadLine();
                while (string.IsNullOrEmpty(a.district))
                {
                    Console.WriteLine("Введіть район мiста:");
                    a.district=Console.ReadLine();
                }
                using(StreamWriter f = new StreamWriter("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt",true))
                    f.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}",a.name,a.adress,a.LastName,a.houses,a.district);
            }
    
            public void Edit()
            {
                JCity a = new JCity();
                string[] str = File.ReadAllLines("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt");
                Console.WriteLine("Номер рядку:");
                int line = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Назва");
                a.name=Console.ReadLine();
                while (string.IsNullOrEmpty(a.name))
                {
                    Console.WriteLine("Введiть назву:");
                    a.name=Console.ReadLine();
                }
                Console.WriteLine("Адреса");
                a.adress = Console.ReadLine();
                while (string.IsNullOrEmpty(a.adress))
                {
                    Console.WriteLine("Введiть адресу:");
                    a.adress=Console.ReadLine();
                }
                Console.WriteLine("Прiзвище начальника");
                a.LastName= Console.ReadLine();
                while (string.IsNullOrEmpty(a.LastName))
                {
                    Console.WriteLine("Введiть прiзвище начальника:");
                    a.LastName=Console.ReadLine();
                }
                Console.WriteLine("Кiлькiсть пiдзвiтнiх будинкiв");
                a.houses= Int32.Parse(Console.ReadLine());
                Console.WriteLine("Район мiста");
                a.district=Console.ReadLine();
                while (string.IsNullOrEmpty(a.district))
                {
                    Console.WriteLine("Введіть район мiста:");
                    a.district=Console.ReadLine();
                }
                str[line]=$"{a.name,-20}{a.adress,-20}{a.LastName,-20}{a.houses,-20}{a.district,-20}";
                using (StreamWriter f =
                    new StreamWriter("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt"))
                {
                    f.WriteLine(
                        $"{"Назва",-20}{"Адреса",-20}{"Прiзвище начальника",-20}{"Кiлькiсть будинкiв",-20}{"Район мiста",-20}");
                    for (int i = 1; i < str.Length; i++)
                    {
                        if (i != line)
                        {
                            f.WriteLine(str[i]);
                        }
                        else f.WriteLine(str[line]);
                    }
                }
    
            }
    
            public void Remove()
            {
                Console.WriteLine("Номер рядкa:");
                int line = Int32.Parse(Console.ReadLine());
                string[] str = File.ReadAllLines("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt");
                using (StreamWriter f =
                    new StreamWriter("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt"))
                {
                    f.WriteLine($"{"Назва",-20}{"Адреса",-20}{"Прiзвище начальника",-20}{"Кiлькiсть будинкiв",-20}{"Район мiста",-20}");
                    for (int i = 1; i < str.Length; i++)
                    {
                        if (i != line)
                        {
                            f.WriteLine(str[i]);
                        }
    
                    }
                }
            }
    
            public void Output()
            {
                JCity a = new JCity();
                string[] str = File.ReadAllLines("C:\\Users\\vladi\\RiderProjects\\Lab43\\NewFile1.txt");
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
    
            public void Search()
            {
                JCity a = new JCity();
                string[] str = File.ReadAllLines("C:\\Users\\s\\RiderProjects\\ConsoleApp7\\ConsoleApp7\\NewFile1.txt");
                Console.WriteLine("Мiсто:");
                var city=Console.ReadLine();
                while (string.IsNullOrEmpty(city))
                {
                    Console.WriteLine("Введiть мiсто:");
                    city=Console.ReadLine();
                }
                int k = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].Contains(city))
                    {
                        k++;
                        if (k == 1)
                        {
                            Console.WriteLine($"{"Назва",-20}{"Адреса",-20}{"Прiзвище начальника",-20}{"Кiлькiсть будинкiв",-20}{"Район мiста",-20}");
                            Console.WriteLine(str[i]);
                        }
                        else Console.WriteLine(str[i]);
                    }
                }
            }
    
        }
        class Program
        {
            static void Main(string[] args)
            {
                JCity city = new JCity();
                Console.WriteLine("\nВибiр режиму роботи: ");
                Console.WriteLine("Додавання записiв - Q");
                Console.WriteLine("Редагування записiв - W");
                Console.WriteLine("Знищення записiв - E");
                Console.WriteLine("Виведення iнформацiї з файла на екран - R");
                Console.WriteLine("Пошук потрiбної iнформацiї за конкретною ознакою - T");
                ConsoleKeyInfo k;
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Q)
                {
                    city.Add();
                }
    
                if (k.Key == ConsoleKey.W)
                {
                    city.Edit();
                }
    
                if (k.Key == ConsoleKey.E)
                {
                    city.Remove();
                }
    
                if (k.Key == ConsoleKey.R)
                {
                    city.Output();
                }
    
                if (k.Key == ConsoleKey.T)
                {
                    city.Search();
                }
    
            }
    
        }
    }