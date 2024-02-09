using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    internal class Fecha
    {
        private int fDay;
        private int fMonth;
        private int fYear;

        public Fecha()
        {
            fDay = 0;
            fMonth = 0;
            fYear = 0;
        }
        public int Year
        {
            get { return fYear; }
            set { if (value > 0) { fYear = value; } }
        }

        public int Month
        {
            get { return fMonth; }
            set { if (value < 13 && value > 0) { fMonth = value; } }
        }

        public int Day
        {
            get { return fDay; }
            set
            {
                fDay = value;
                if (fMonth == 2)
                {
                    if (fDay < 30 && fDay > 0 && (fYear % 4 == 0 || fYear % 400 == 0))
                    {
                        fDay = value;
                    }
                    else if (fDay < 29 && fDay > 0)
                    {
                        fDay = value;
                    }
                    else { fDay = 0; }
                }
                else if (fMonth == 1 || fMonth == 3 || fMonth == 5 || fMonth == 8 || fMonth == 10 || fMonth == 12)
                {
                    if (fDay < 32 && fDay > 0)
                    {
                        fDay = value;
                    }
                }
                else if (fDay > 0 && fDay < 31)
                {
                    fDay = value;
                }
                else { fDay = 0; }
            }
        }

        public int orderList(bool asc)
        {
            List<Fecha> salida = new List<Fecha>();
            bool cont = true;
            salida.Add()
            for (int i = 1; i < ; i++)
            {
                for (int k = salida.Count() - 1; k > 0 && cont; k--)
                {
                    if (fechaList[i] > salida[k])
                    {

                    }
                }
            }
            
        }
    }
}
