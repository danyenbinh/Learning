using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanpham
{
    public partial class product
    {
        public Manufactory manufatory{set; get;}
        public class Manufactory
        {
            public string name { set; get; }
            public string Navi { set; get; }
        }
        public string description { set; get; }
    }
    
}
