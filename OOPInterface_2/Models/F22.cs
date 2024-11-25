using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterface_2.Models
{
    public class F22 : HavaAraci,IGorunmezHavaAraci
    {
        public int Deneme { get; set; }

        public void Gorunmezlik()
        {
            throw new NotImplementedException();
        }
    }
}
