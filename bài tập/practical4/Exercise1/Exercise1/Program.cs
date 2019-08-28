using System;
using Exercise1.Exercise1;
using System.Collections;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        public static Hashtable StudentList = new Hashtable();
        public static int Id = 0;
        static void Main(string[] args)
        {
            DrawMenu();

        }

        public static void DrawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("****************");
                Console.WriteLine("STUDENT SYSTEM MANAGEMENT");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View List of Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("Please chose option from 1 to 4");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    option = num;
                };
            }
            while (option > 4 || option < 1);
            Process(option);
        }

        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    Console.WriteLine("Insert New student\n");
                    CreateStuden();
                    break;

                case 2:
                    Console.WriteLine("View list of student \n");
                    ViewStudent();
                    break;

                case 3:
                    Console.WriteLine("Search student \n");
                    break;

                case 4:
                default:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
            DrawMenu();
        }

        public static void CreateStuden()
        {
            var student = new Student();
            Id = Id + 1;
            student.ID = Id;
            Console.Write("Input FullName: ");
            student.FullName = Console.ReadLine();
            Console.Write("Input DateOfBirt: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime result))
            {
                student.DateOfBirth = result;
            };
            Console.Write("Input Native: ");
            student.Native = Console.ReadLine();
            Console.Write("Input Class: ");
            student.ClassName = Console.ReadLine();
            Console.Write("Input PhoneNo: ");
            student.PhoneNo = Console.ReadLine();
            Console.Write("Input Number:");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                student.Mobile = num;
            }

            StudentList.Add(Id, student);

        }
        public static void ViewStudent()
        {

            //foreach (DictionaryEntry student in StudentList)
            //{
            //    Console.WriteLine(student.Value.ToString());
            //}
            foreach(KeyValuePair<int, Student> item in StudentList)
            {
              item.Value.Display();
            }
            
            //var student = new Student();
            //var keys = StudentList.Keys;
            //foreach(Keyva)
            //{
            //}
        }

        public static void SearchStudent()
        {

        }
    }
}
