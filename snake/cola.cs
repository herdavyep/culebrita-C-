using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class cola : objeto
    {
        cola siguiente;
        

        public cola(int posicionX, int posicionY)
        {
            this.posX = posicionX;
            this.posY = posicionY;
            siguiente = null;
        }

        public void dibujar (Graphics g)
        {
            if(siguiente != null)
            {
                siguiente.dibujar(g);
            }
            g.FillRectangle(new SolidBrush(Color.Pink), this.posX, this.posY, this.width, this.width);
            
        }

        public void setXY (int posicionX, int posicionY)
        {
            if(siguiente != null)
            {
                siguiente.setXY(this.posX, this.posY);
            }
            this.posX = posicionX;
            this.posY = posicionY;
        }

        public void meter()
        {
            if(siguiente == null)
            {
                siguiente = new cola(this.posX, this.posY);
            }
            else
            {
                siguiente.meter();
            }
        }

        public int verPosX()
        {
            return this.posX;
        }

        public int verPosY()
        {
            return this.posY;
        }

        public cola verSiguiente()
        {
            return siguiente;
        }
    }
}
