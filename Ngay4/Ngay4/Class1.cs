using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanpham
{
    public partial class product
    {
        public string name { set; get; }
        public decimal price { set; get; }
        public string Getinfor()
        {
            
            return $"{name} / {price} : {description} :{manufatory.name}";
        }
    }
}
