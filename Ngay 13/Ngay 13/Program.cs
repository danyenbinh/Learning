using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngay_13
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class MotaAttribute : Attribute
    {
        public string Thongtinchitiet { set; get; }
        public MotaAttribute(string _Thongtinchitiet)
        {
            Thongtinchitiet = _Thongtinchitiet;
        }
    }
    
    public class user
    {
        [Required(ErrorMessage = "Name phai thiet lap")]    
        [StringLength(50,MinimumLength =3, ErrorMessage ="Ten phai dai tu 3-100 ky tu")]
        public string Name { set; get; }
        [Range(18,80,ErrorMessage ="18-80")]
        public int Age { set; get; }
        [Phone(ErrorMessage ="loi")]
        public string Phonenumber { set; get; }
        [EmailAddress(ErrorMessage ="sai cau truc")]
        public string Email { set; get; }
        
        public void PrintInfo() => Console.WriteLine(Name);
    }
    class Program
    {
        //Type->class,struct,....,int,bool,...
        //Attribute
        static void Main(string[] args)
        {
            /*int[] a= { 1, 2, 3 };
            Type t1 = typeof(int);
            var t2 = typeof(string);
            var t3 = typeof(Array);

            Type t = a.GetType();
            Console.WriteLine(t.FullName);

            Console.WriteLine("Cac thuoc tinh: ");
            t.GetProperties().ToList().ForEach((o) =>
            {
                Console.WriteLine(o.Name);
            });
            Console.WriteLine("Cac truong du lieu: ");
            t.GetFields().ToList().ForEach(( o) =>
            {
                Console.WriteLine(o.Name);
            });

            Console.WriteLine("Cac phuong thuc: ");
            t.GetMethods().ToList().ForEach((o) =>
            {
                Console.WriteLine(o.Name);
            });
*/
            user user = new user()
            {
                Name = "MVH",
                Age = 20,
                Phonenumber = "2312312312",
                Email = "123asd",

            };
            /*var properties = user.GetType().GetProperties();
            foreach (var p in properties)
            {
                foreach(var attr in p.GetCustomAttributes(false))
                {
                    MotaAttribute mota = attr as MotaAttribute;
                    if (mota != null)
                    {
                        Console.WriteLine(mota.Thongtinchitiet);
                        var value = p.GetValue(user);
                        var name = p.Name;
                        Console.WriteLine($"({name}) - {mota.Thongtinchitiet}:{value}");
                    }
                }

            }*/
            ValidationContext context = new ValidationContext(user);
            var result = new List<ValidationResult>();
            bool kq=Validator.TryValidateObject(user, context, result, true);
            if (kq == false)
            {
                result.ToList().ForEach((er) =>
                {
                    Console.WriteLine(er.MemberNames.First());
                    Console.WriteLine(er.ErrorMessage);
                });
            }


        }
    }
}
