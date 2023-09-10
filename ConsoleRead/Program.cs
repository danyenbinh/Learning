 namespace ConsoleRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Console.Read();

            //Console.WriteLine(Console.Read()); //đọc 1 ký tự từ bàn phím bằng lệnh console.read() sau đó in ra ký tự vừa đọc

            //Console.ReadKey();//dừng màn hình để xem kết quả

            #endregion

            #region Console.ReadLine();

            //Console.WriteLine(Console.ReadLine()); //Đọc dữ liệu từ bàn phím cho đến khi gặp ký tự xuống dòng thì dừng. Sau đó in ra kí tự tương ứng vừa nhập

            //Console.ReadKey(); //dừng màn hình để xem kết quả

            #endregion

            #region Console.ReadKey();

            //Console.WriteLine("Boy lanh lung");

            //Console.ReadKey(); //không truyền tham số vào thì mặc định là false

            //Console.ReadKey(false); //hiển thị phím án lên màn hình

            //Console.ReadKey(true); //không hiển thị phím ấn lên màn hình


            #endregion

        }
    }
}