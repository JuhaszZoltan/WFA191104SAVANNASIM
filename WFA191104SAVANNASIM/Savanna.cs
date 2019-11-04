using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191104SAVANNASIM
{
    class Savanna
    {
        public PictureBox[,] Terulet { get; set; }

        public Savanna(int s, int o)
        {
            Terulet = new PictureBox[o, s];
        }
    }
}
