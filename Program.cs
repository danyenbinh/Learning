using System;

namespace LearnCSharpHowKTeam2023
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Console.WriteLine("Hello World!");
            Console.Write("TuNguyen");
            Console.ReadKey();*/


            #region Console.WriteLine()
            /*Console.Write("Say hi \n"); // Sử dụng ký tự đặc biệt để xuống dòng
            Console.WriteLine(5); // Sử dụng lệnh in ra màn hình có xuống dòng
            Console.Write(6.5f); // In ra giá trị nhưng không xuống dòng
            Console.Write(Environment.NewLine); // sử dụng lệnh xuống dòng
            Console.Write(true);

            Console.ReadLine();*/
            #endregion

            /*int a = 5; // khai báo biến kiểu nguyên có tên là a và khởi tạo giá trị là 5.
            Console.Write("a = "); // In ra màn hình giá trị "a = ".
            Console.Write(a); // In ra giá trị của a là 5*/

            /*int a = 5; // khai báo biến kiểu nguyên có tên là a và khởi tạo giá trị là 5.
            Console.Write("a = {0}", a); // In ra màn hình giá trị "a = 5".*/

            #region Vi du chuong trinh nhap xuat co ban trong C#

            Console.WriteLine("       Say hi"); // In chữ "K team" sau đó xuống dòng.
            Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
            Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
            Console.Write(" Moi ban nhap ngay sinh: ");
            Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
            Console.Write(" Moi ban nhap que quan: ");
            Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.

            Console.ReadKey();





















            #endregion


        }

    }
}
/*namespace Cau_Truc_Lenh_Co_Ban
{
    public class Action { }

    public delegate void Art();

    namespace Sub_Namespace { }
}*/


