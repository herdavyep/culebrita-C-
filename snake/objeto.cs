using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class objeto
    {
        protected int posY, posX, width;

        public objeto()
        {
            width = 10;
        }
        public Boolean intersection(objeto o)
        {
            int diferenciaX = Math.Abs(this.posX - o.posX);
            int diferenciaY = Math.Abs(this.posY - o.posY);

            if (diferenciaX >=0 && diferenciaX < width && diferenciaY >=0 && diferenciaY < width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
