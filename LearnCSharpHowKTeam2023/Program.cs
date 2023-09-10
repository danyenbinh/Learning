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

            /*Console.WriteLine("       Say hi"); // In chữ "K team" sau đó xuống dòng.
            Console.Write(" Moi ban nhap ten cua minh: "); // In không xuống dòng.
            Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó. Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() sau đó thực hiện cộng chuỗi và cuối cùng in chuỗi ra màn hình.
            Console.Write(" Moi ban nhap ngay sinh: ");
            Console.WriteLine(" Ngay sinh cua ban la: " + Console.ReadLine()); // Tương tự như trên
            Console.Write(" Moi ban nhap que quan: ");
            Console.WriteLine(" Que quan: " + Console.ReadLine()); // Tương tự như trên.

            Console.ReadKey();*/
            #endregion

            #region Bai 4 Bien
            // Bien -> co the thay doi
            /* - La mot gia tri du lieu co the thay doi duoc
             - La ten goi tham chieu den mot vung nho nao do trong bo nho
             - La thanh phan cot loi cua mot ngon ngu lap trinh*/

            // Why
            /*- luu tru du lieu va tai su dung
                -thao tac voi bo nho mot cach de dang*/

            /* <Kieu du lieu> <Ten bien> */

            // Quy tac dat ten bien
            /*- Ten bien la mot chuoi ki tu lien ket(khong co khoang trang) va khong chua ki tu dac biet
              - khong duoc dat bang tieng viet co dau
              - khong duoc bat dau bang so
              - Ten bien khong duoc trung nhau
              - khong duoc trung voi tu khoa
            */

            // Quy tac lac da:
            /*- viet thuong chu dau tien va viet hoa chu cai dau tien cua nhung tu tiep thep -> tuNguyen
            - Thuong dung cho private, protected
            */

            // Quy tac pascal:
            /*- Viet hoa chu cai dau tien cua moi tu -> TuNguyen
            - Con lai
            */

            // Chu y
            /*- Nen dat ten ngan gon de hieu, the hien ro muc dich cua bien
            - Co phan biet chu hoa va thuong  */

            /*int KieuSoNguyen = 9;
            float BienKieuSoThuc = 6.9f;
            string BienKieuChuoi = "Tu Nguyen";
            bool BienKieuLuanLy = true;
            char BienKieuKyTu = 'T';

            int aNum = 6;
            int bNum = 9;
            int cNum = aNum + bNum;

            // In gia tri cua bien KieuSoNguyen ra man hinh
            //Console.WriteLine(KieuSoNguyen);

            Console.WriteLine("a + b = c : {0} + {1} = {2}" , aNum, bNum, cNum);

            Console.ReadKey();*/
            #endregion

            #region Bai 5 kieu du lieu
            // Kieu du lieu
            /*- La tap hop cac nhom du lieu co cung dac tinh
              - Cach lu tru va thao tac xu ly tren truong du lieu do
              - La mot tin hieu de trinh bien dich nhan biet kich thuoc cua mot bien va kha nang cua no
              - La thanh phan cot loi cua mot ngon ngu lap trinh
              - Dung san -> Kieu du lieu gia tri
              - Tu dinh nghia -> Kieu du lieu tham chieu*/


            /*//*//* Vi du 1
            // Kiểu số nguyên
            *//*byte BienByte = 10;
            short BienShort = 10;
            int BienInt = 10;
            long BienLong = 10;

            // Kiểu số thực
            float BienFloat = 10.9f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
            double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
            decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

            // Kiểu ký tự và kiểu chuỗi
            char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
            string BienString = "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong *//*cặp dấu "" (nháy kép).*//*/

            /// Vi du 2
            // Kiểu số nguyên
            byte BienByte = 3;
            short BienShort = 9;
            int BienInt = 10;
            long BienLong = 0;

            BienLong = BienByte; // BienLong có kiểu dữ liệu lớn hơn BienByte nên giá trị BienByte có thể gán qua cho BienLong
            Console.WriteLine(" BienLong = " + BienLong);

            BienLong = BienInt; // tương tự như trên
            Console.WriteLine(" BienLong = {0}", BienLong);

            BienShort = BienByte; // tương tự như trên
            Console.WriteLine(" BienShort = " + BienShort);

            BienInt = BienShort; // tương tự như trên
            Console.WriteLine(" BienInt = " + BienInt);

            Console.ReadKey();*/

            /*// Vi du 3
            int a;
            Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.

            int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.

            byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá ngoài vùng này được.

            string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bẳng cặp dấu "" thay vì ''. 

            long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte, . . .
            long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?

            int g = 10;
            byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn mặc dù trong trường hợp này ta thấy số 10 đều có thể gán cho 2 biến.

            string k = "Kteam";
            Console.WriteLine(" k = " + K); // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K (C# có phân biệt chữ hoa, thường cần lưu ý để tránh gặp lỗi)

            Console.ReadKey();*/
















            #endregion

            #region Bai 6 Toan tu trong c#

            /*int i = 5, j = 5;

            Console.WriteLine(i++); // Sử dụng giá trị i để in ra rồi mới tăng i
            Console.WriteLine(++j); // Tăng j lên rồi mới in giá trị j ra màn hình

            Console.ReadKey();*/


            /*int H, K, T;
            H = K = T = 10;
            Console.WriteLine(" H = {0}, K = {1}, T = {2}", H, K, T);

            H += K = T = 5;
            Console.WriteLine(" H = {0}, K = {1}, T = {2}", H, K, T);*/

            /*// Vi du mot cac phep toan co ban
            int a, b, c;

            a = b = (c = 9) + 1; // khởi tạo giá trị: a = 10, b = 10, c = 9
            a += b; // tương đương a = a + b
            b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1
            --c; // thực hiện c = c - 1

            Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);

            Console.ReadKey();*/

            // Vi du 2 

            /*string strSoNguyen; // Biến chứa dữ liệu nhập vào từ bàn phím
            int SoNguyen; // Biến chứa số nhập vào từ bàn phím
            string KetQua; // Biến chứa kết quả kiểm tra số vừa nhập là chẵn hay lẻ

            strSoNguyen = Console.ReadLine(); // Đọc dữ liệu nhập vào từ bàn phím (dữ liệu này ở dạng chuỗi) sau đó gán giá trị vào biến strSoNguyen
            SoNguyen = Int32.Parse(strSoNguyen); // Ép kiểu dữ liệu vừa nhập vào (dạng chuỗi) sang dạng số rồi gán giá trị vào biến SoNguyen
            KetQua = (SoNguyen % 2 == 0) ? "so chan" : "so le"; // Sử dụng toán tử 3 ngôi để kiểm tra số chẵn lẻ

            Console.WriteLine("{0} la {1}", SoNguyen, KetQua); // In kết quả ra màn hình

            Console.ReadKey();*/

            #endregion

            #region Bai 7 Hằng trong c#
            /*int a = 15;
            const int x = a;
            Console.WriteLine(x);
            Console.ReadKey();*/
            #endregion

            #region Bai 8 Ep kieu

            // Cac kieu ep kieu trong C#
            /*Chuyển đổi ngầm định
            Chuyển đổi tường minh
            Sử dụng phương thức, lớp hỗ trợ sẵn => Parse(), TryParse(); Convert
            Người dùng tự định nghĩa kiểu chuyển đổi*/

            // Chuyển đổi kiểu ngầm định
            /*int intValue = 10;
            long longValue = intValue; *//* Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển từ int sang long.*//*
            float floatValue = 10.9f;
            double doubleValue = floatValue; *//* Tương tự vì kiểu double có miền giá trị lớn hơn kiểu float nên có thể chuyển từ float sang double.*/

            // Chuyển đổi kiểu tường minh
            /*int i = 300; // 300 có mã nhị phân là 100101100
            byte b = (byte)i;
            *//* do kiểu byte có giới hạn đến giá trị 255 thôi nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 bytes tương đương 8 bit. Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được. Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit) tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.*//*

            Console.WriteLine(" i = " + i);
            Console.WriteLine(" b = " + b);
            double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; // Ép kiểu số 2 từ kiểu nguyên sang kiểu số thực. Như vậy kết quả phép chia sẽ ra số thực
            double t = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với 2 mục đích để biến số 2 (số nguyên) thành 2.0 (số thực)

            Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d, k, t);
            Console.ReadKey();*/

            /*int i = 300; // 300 có mã nhị phân là 100101100
            byte b = (byte)i;
            *//* do kiểu byte có giới hạn đến giá trị 255 thôi nên không thể chứa số 300 được mà kiểu byte có kích thước là 1 bytes tương đương 8 bit. Như vậy ta cần cắt mã nhị phân của số 300 về còn 8 bit là được. Mã nhị phân 300 là 100101100 cắt từ trái qua 1 bit ta được 00101100 (đủ 8 bit) tương đương với số 44. Cuối cùng biến b sẽ mang giá trị là 44.*//*

            Console.WriteLine(" i = " + i);
            Console.WriteLine(" b = " + b);

            int a = 5;
            int c = 2;
            float tt = a * 1.0f / c; //  => 2,5
            double d = 2 / 3; // kết quả ra 0 vì 2 và 3 đều là số nguyên nên thực hiện 2 chia lấy phần nguyên với 3 được 0
            double k = (double)2 / 3; // Ép kiểu số 2 từ kiểu nguyên sang kiểu số thực. Như vậy kết quả phép chia sẽ ra số thực
            double t = 1.0 * 2 / 3; // Thực hiện nhân 1.0 với 2 mục đích để biến số 2 (số nguyên) thành 2.0 (số thực)

            Console.WriteLine(" d = {0} \n k = {1} \n t = {2}", d, k, t);
            Console.ReadKey();*/

            // Sử dụng phương thức, lớp hỗ trợ sẵn

            // Parse()
            /*string stringValue = "10";
            int intValue = int.Parse(stringValue); // Chuyển chuỗi stringValue sang kiểu int và lưu giá trị vào biến intValue - Kết quả intValue = 10
            double HowKteam = double.Parse("10.9"); // Chuyển chuỗi giá trị hằng "10.9" sang kiểu int và lưu giá trị vào biến HowKteam - Kết quả HowKteam = 10.9
*/
            // TryParse()
            /*int Result; // Biến chứa giá trị kết quả khi ép kiểu thành công
            bool isSuccess; // Biến kiểm tra việc ép kiểu có thành công hay không
            string Data1 = "10", Data2 = "Kteam"; // Dữ liệu cần ép kiểu

            isSuccess = int.TryParse(Data1, out Result); // Thử ép kiểu Data1 về int nếu thành công thì Result sẽ chứa giá trị kết quả ép kiểu và isSuccess sẽ mang giá trị true. Ngược lại Result sẽ mang giá trị 0 và isSuccess mang giá trị false
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Sử dụng toán tử 3 ngôi để in ra màn hình việc ép kiểu đã thành công hay thất bại.
            Console.WriteLine(" Result = " + Result); // In giá trị Result ra màn hình

            isSuccess = int.TryParse(Data2, out Result); // Tương tự như trên nhưng thao tác với Data2
            Console.Write(isSuccess == true ? " Success !" : " Failed !"); // Tương tự như trên
            Console.WriteLine(" Result = " + Result); // Tương tự như trên*/

            // Lớp hỗ trợ sẵn (Convert)

            /*int A, B; // Biến chứa giá trị 2 số vừa nhập vào (kiểu số)
            int Tong, Hieu, Tich; // Biến chứa kết quả tổng, hiệu, tích
            double Thuong; // Vì phép chia có thể cho ra số thập phân nên dùng biến kiểu double để chứa nó.
            string strA, strB; // Biến chứa giá trị 2 số nhập vào từ bàn phím (kiểu chuỗi)

            Console.WriteLine("         **************************************************");
            Console.WriteLine("         *                                         			       *");
            Console.WriteLine("         *   Chuong trinh tinh tong, hieu, tich, thuong  *");
            Console.WriteLine("         *                                            		       *");
            Console.WriteLine("         **************************************************");

            Console.Write("\n Moi ban nhap so A: ");
            strA = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số A
            Console.Write(" Moi ban nhap so B: ");
            strB = Console.ReadLine(); // Nhận giá trị nhập vào từ bàn phím cho số B

            A = int.Parse(strA); // Ép kiểu giá trị nhập vào từ kiễu chuỗi sang kiểu số nguyên, sử dụng phương thức Parse()
            B = int.Parse(strB); // Tương tự

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B; // Ép kiểu số A về số thập phân để phép chia cho ra số thập phân

            Console.WriteLine(" Tong = " + Tong);
            Console.WriteLine(" Hieu = " + Hieu);
            Console.WriteLine(" Tich = " + Tich);
            Console.WriteLine(" Thuong = " + Thuong);*/

            #endregion

            #region Bai 9 Cấu trúc dẽ nhánh If Else
            // Câu điều kiện dạng thiếu 
            /*string T = "TuNguyen";
            if (T == "TuNguyen")
                // Biểu thức điều kiện sử dụng toán tử == đề so sánh xem giá trị biến K có bằng “Kteam” hay không. Nếu bằng trả thì trả về true ngược lại thì trả về false.
                Console.WriteLine("Free Fire"); // In ra màn hình chữ “Free Education” nếu biểu thức trên đúng.*/

            // Câu điều kiện dạng đủ
            /*string T = "TuNguyen";

            if (T == "TuNguyen1") // Nếu giá trị K bằng “TuNguyen” thì
                Console.WriteLine("Free Fire"); // In ra màn hình “Free Fire”
            else // Ngược lại thì
                Console.WriteLine("Connecting to TuNguyen. . ."); // In ra màn hình “Connecting to TuNguyen. . .”
*/
            /*string T = "10-09";
            if ( T == "TuNguyen")
            {
                Console.WriteLine("TuNguyen.vn");
                Console.WriteLine("Free Fire");
            }    
            else if (T == "Tu")
            {
                Console.WriteLine("Share to be stupit");
            }    
            else
            {
                if (T == "10-09")
                {
                    Console.WriteLine("Public Website TuNguyen.vn");
                }    
                else
                {
                    Console.WriteLine(" Conecting to the Free Fire World");
                }    
                
            }    */



            /*string tuNguyen = "TuNguyen";
            bool isTuNguyen = tuNguyen == "TuNguyen" ? true : false;

            if (isTuNguyen)
            {
                Console.WriteLine("Welcome to my house");
            }    
            else
            {
                Console.WriteLine("Share to be bad");
            }

            Console.ReadLine();*/

            /*string tuNguyen = "TuNguyen";
            //bool isTuNguyen = tuNguyen == "TuNguyen" ? true : false;

            if (tuNguyen == "TuNguyen" ? true : false)
            {
                Console.WriteLine("Welcome to my house");
            }
            else
            {
                Console.WriteLine("Share to be bad");
            }

            Console.ReadLine();*/

            // Vi du
            /*string strA, strB;
            int A, B;
            double Nghiem;

            Console.WriteLine("         ***************************************************");
            Console.WriteLine("         *                                        			        *");
            Console.WriteLine("         *    Chuong trinh giai phuong trinh Ax + B = 0 *");
            Console.WriteLine("         *                                                 		        *");
            Console.WriteLine("         ***************************************************");

            Console.Write(" Moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write(" Moi nhap so B: ");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false) // kiểm tra người dùng có thực sự nhập số nguyên vào hay không. Nếu ép kiểu thành công sẽ trả về true, ngược lại trả về false
            {
                Console.WriteLine(" Du lieu nhap sai !");
                return; // Lệnh này tạm hiểu là dừng và thoát chương trình mà không thực hiện những câu lệnh sau nó nữa. Sẽ được tìm hiểu chi tiết trong bài 16 Hàm
            }
            else
            {
                Console.WriteLine("\n Phuong trinh cua ban vua nhap la: {0}x + {1} = 0", A, B);

                if (A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem !");
                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x = 0");
                }
                else
                {
                    Nghiem = (double)-B / A; // Ép kiểu để cho ra kết quả chính xác
                    Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Nghiem);
                }
            }*/

            #endregion

            #region Bai 10 Cấu trúc Switch case

            // Switch dạng thiếu
            /*int k = 10;

            switch (k) // giá trị biểu thức là giá trị của biến k (kiểu số nguyên)
            {
                case 3: // các giá trị so sánh cũng là kiểu số nguyên
                    Console.WriteLine("HowKteam"); // lệnh thực hiện nếu k = 3
                    break; // lệnh thoát ra khỏi cấu trúc
                case 9:
                    Console.WriteLine("Kteam"); // tương tự
                    break;
                case 10:
                    Console.WriteLine("Free Education"); // tương tự
                    break;
            }
            Console.ReadKey();*/

            // Switch dạng đủ
            /*int k = 8;

            switch (k)
            {
                case 3:
                    Console.WriteLine("HowKteam");
                    break;
                case 9:
                    Console.WriteLine("Kteam");
                    break;
                case 10:
                    Console.WriteLine("Free Education");
                    break;
                default: // Nếu không thỏa các trường hợp trên sẽ thực hiện lệnh sau đây
                    Console.WriteLine("Connecting to HowKteam. . .");
                    break;
            }
            Console.ReadKey();*/

            // Vi du
            /*int Year; // Biến chứa giá trị năm cần tính.
            string Can = "", Chi = ""; // Biến chứa kết quả.

            Console.Write(" Moi ban nhap mot nam bat ky: ");
            Year = Int32.Parse(Console.ReadLine()); // Nhập năm dương lịch và ép kiểu về kiểu số nguyên

            switch (Year % 10) // Tìm Can như thuật toán đã trình bày.
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Can
                    Can = "Canh"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Can = "Tan";
                    break;
                case 2:
                    Can = "Nham";
                    break;
                case 3:
                    Can = "Quy";
                    break;
                case 4:
                    Can = "Giap";
                    break;
                case 5:
                    Can = "At";
                    break;
                case 6:
                    Can = "Binh";
                    break;
                case 7:
                    Can = "Dinh";
                    break;
                case 8:
                    Can = "Mau";
                    break;
                case 9:
                    Can = "Ky";
                    break;
            }

            switch (Year % 12) // Tìm Chi như thuật toán đã trình bày
            {
                case 0: // Mỗi case này tương ứng một kết quả cần tra cứu trong bảng tra cứu Chi
                    Chi = "Than"; // Giá trị tương ứng với mỗi case
                    break;
                case 1:
                    Chi = "Dau";
                    break;
                case 2:
                    Chi = "Tuat";
                    break;
                case 3:
                    Chi = "Hoi";
                    break;
                case 4:
                    Chi = "Ty";
                    break;
                case 5:
                    Chi = "Suu";
                    break;
                case 6:
                    Chi = "Dan";
                    break;
                case 7:
                    Chi = "Meo";
                    break;
                case 8:
                    Chi = "Thin";
                    break;
                case 9:
                    Chi = "Ti";
                    break;
                case 10:
                    Chi = "Ngo";
                    break;
                case 11:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can, Chi); // Nối Can và Chi lại để được năm âm lịch

            Console.ReadLine();
            Console.ReadKey();*/

            #endregion

            #region Bài 11 Kiểu dữ liệu Object
            // boxing: chuyển từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu
            // Khởi tạo biến Value kiểu int (kiểu dữ liệu giá trị)
            /*int Value = 109;

            *//* thực hiện boxing bằng cách:
             * Khởi tạo đối tượng ObjectValue kiểu object 
             * Gán giá trị của biến Value vào ObjectValue *//*
            object ObjectValue = Value;

            int newValue = (int)ObjectValue;*/

            // Từ khóa Var
            /* Vì biến StringVariable được khởi tạo giá trị kiểu chuỗi 
             * nên trình biên dịch sẽ hiểu biến này như là biến kiểu string.
             */
            /*var varString = "HowKteam";
            // Khai báo tường minh biến kiểu string
            string Content = "HowKteam";

            // In giá trị của biến StringVariable và biến Content
            Console.WriteLine(varString);
            Console.WriteLine(Content);*/

            #endregion

            #region Bài 12 Kiểu dữ liệu Dynamic
            // Đặc điểm của Dynamic
            /*// Khai báo biến StringValue kiểu dynamic và khởi tạo giá trị là một chuỗi kiểu string
            dynamic StringValue = "HowKteam";
            *//* 
            * Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++
            * Nhưng câu lệnh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định kiểu dữ liệu cho biến StringValue
            * Khi chạy chương trình thì lúc này C# mới phát hiện biến StringValue là kiểu string và không thể thực hiện toán tử ++ lúc đó sẽ xuất hiện lỗi
            *//*
            StringValue++;*/

            // Ví dụ
            /*// Khai báo 2 biến Name và Mission kiểu string và khởi tạo giá trị.
            string Name = "HowKteam ";
            string Mission = "Free Education";

            *//* 
             * Thực hiện gán 1 biến kiểu string cho biến kiểu dynamic bằng cách ép kiểu ngầm định (implicit)
             * Sau phép gán này thì biến DynamicValue chứa giá trị là "Free Education" nhưng kiểu dữ liệu của nó vẫn chưa được xác định.
            *//*
            dynamic DynamicName = Name;

            // Thực hiện cộng chuỗi và in ra màn hình bình thường
            Console.WriteLine("Mission of " + DynamicName + " is " + Mission);*/

            #endregion

            #region Bài 13 Giới thiệu cấu trúc vòng lặp
            // vòng lặp kết thúc khi đủ 10 lần
            /*Lặp 10 lần
{
                Console.WriteLine("HowKteam.com");
            }

            int i = 0;
            // vòng lặp kết thúc khi điều kiện dừng thỏa là i > 10 hay I == 11
            Lặp đến khi i > 10
{
                Console.WriteLine("HowKteam.com");
                i++; // i tăng thêm một đơn vị [0, 1, 2, 3, .., 10, 11]
            }

            int i = 0;
            // vòng lặp không kết thúc vì i mãi == 0
            Lặp đến khi i > 10
{
                Console.WriteLine("HowKteam.com");
            }*/

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


