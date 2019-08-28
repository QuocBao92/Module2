using System;

namespace Exercise2
{
    class Program
    {
        public static int Id = 0;
        public static CustomList movieList = new CustomList();
        static void Main(string[] args)
        {
            DrawMenu();
        }

        public static void DrawMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("************");
                Console.WriteLine("MOVIE MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert new Movie");
                Console.WriteLine("2. View list of Movie");
                Console.WriteLine("3. Sort Movie by Average List");
                Console.WriteLine("4. Delete a Movie");
                Console.WriteLine("5. Exit\n");
                Console.WriteLine("Plese select option from 1 to 5");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out int num)) {
                    option = num;
                }
            }
            while (option > 5 || option < 1);
            Process(option);
        }

        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    Console.WriteLine("Insert new Movie");
                    CreatMovie();
                    break;

                case 2:
                    Console.WriteLine("View list of Movie");
                    ViewListMovie();
                    break;

                case 3:
                    Console.WriteLine("Sort movie by average list");
                    break;

                case 4:

                    break;

                case 5:
                default:
                    Environment.Exit(Environment.ExitCode);
                    break;

            }
            DrawMenu();
        }

        public static void CreatMovie()
        {
            Id = Id + 1;
            var newmovie = new Movie();
            newmovie.ID = Id;
            Console.Write("Movie Name: ");
            newmovie.Name = Console.ReadLine();

            Console.Write("PublistDate Movie: ");
            if(DateTime.TryParse(Console.ReadLine(),out DateTime result)){
                newmovie.PublishDate = result;
            }
            Console.Write("Director movie: ");
            newmovie.Director = Console.ReadLine();
            Console.Write("Subtitle Movie: ");
            newmovie.Subtitle = Console.ReadLine();

            Console.WriteLine("Rate movie !!");
            for (int i = 0; i <newmovie.RateList.Length; i++)
            {
                Console.Write("Rate {0}:", i+1);
                if (double.TryParse(Console.ReadLine(), out double rate))
                {
                    newmovie.RateList[i] = rate;
                }
            }
            movieList.Add(newmovie);
            
        }

        public static void ViewListMovie()
        {
            foreach(Movie item in movieList)
            {
                Console.WriteLine(item.Display());
            }
        }

    }

}
