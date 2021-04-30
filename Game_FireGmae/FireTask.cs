using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_FireGmae
{
    
 public   class FireTask
    {
        Random rd = new Random();
        public int getNumber(int x,int y) {
            return rd.Next(x, y);
        }


    }
}
