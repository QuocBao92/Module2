using System;

namespace Nhap_xuat_co_ban
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console.Writeline()
            Console.Write("Báo đẹp trai .\n");
            Console.WriteLine(10);
            Console.Write(10.9f);
            Console.Write(Environment.NewLine);
            Console.WriteLine(true);
            Console.Read();
            #endregion

            #region Console.Read()
            //int a = 5;
            //Console.Write("{0} {1} {2} {3}", 1, 2, "Bao", "Vip");

            //Console.WriteLine(Console.Read());
            //Console.Read();
            #endregion

            #region Console.Readline()
            //Console.Write(Console.ReadLine());
            //Console.Read();
            #endregion

            #region Console.ReadKey()
            Console.WriteLine("Báo");
            Console.ReadKey();  //Không truyền tham số mặc định là false
            Console.ReadKey(false); // Hiển thị phím bấm lên màn hình
            Console.ReadKey(false); // Hiển thị phím bấm lên màn hình
            Console.ReadKey(true); //thoát và không hiển thị lên màn hình


            #endregion

        }
    }
}
