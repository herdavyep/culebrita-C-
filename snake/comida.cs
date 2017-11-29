using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class comida : objeto
    {
       
        public comida()
        {
            this.posX = generar(66);
            this.posY = generar(26);
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Black), this.posX, this.posY, this.width, this.width);
           
        }
        public void colocar()
        {
            this.posX = generar(66);
            this.posY = generar(26);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 10;
            return num;
        }
    }
}
