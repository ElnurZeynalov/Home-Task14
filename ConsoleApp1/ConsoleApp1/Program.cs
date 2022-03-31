using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hansi Grupa Telbe elave edceksiniz?");
            Console.WriteLine("1.Programming\n2.Desigin\n3.System");
            Type type = (Type)IntAndChoiseChecker("1-3 arasi bir reqerm daxil edin", 0, 4);
            Group group = new Group(type)
            {
                Type = type,
            };
            Console.WriteLine("Nece eded telebe elave edeceksiniz ?");
            int student_value = IntAndChoiseChecker("Yalniz reqerm daxil edin !");
            for (int i = 0; i < student_value; i++)
            {
                Console.WriteLine("Telebe Adi, Soyadi");
                string fullname = Console.ReadLine();
                Student student = new Student()
                {
                    FullName = fullname,
                };
                group.AddStudent(student);
            }
            Console.WriteLine("1.GetStudentByNo2\n2.Quit");
            int menu_choise = IntAndChoiseChecker("1-2 daxil edin", 0, 3);
            bool quit = true;
            do
            {
            switch (menu_choise)
            {
                case 1:
                    Console.WriteLine("Axtarilacaq No daxil edin");
                    int studentno = IntAndChoiseChecker("Yalniz reqem daxil edin");
                        Console.WriteLine(group.GetStudentByNo(studentno).ShowInfo());
                        Console.WriteLine($"Grup nomresi: {group.No}");
                    break;
                case 2:
                    quit = false;
                    break;
                default:
                    break;
            }
            } while (quit);
            
        }
        static int IntAndChoiseChecker(string text , int min=0 , int max=int.MaxValue)
        {
            int value;
            do
            {
                string student_value;
            do
            {
               student_value = Console.ReadLine();
                if (!int.TryParse(student_value, out value))
                    Console.WriteLine(text);
            } while (!int.TryParse(student_value, out value));
            value = Convert.ToInt32(student_value);
                if(!(value > min && value < max))
                    Console.WriteLine(text);
            } while (!(value>min&& value<max));
            return value;
        }
    }
}