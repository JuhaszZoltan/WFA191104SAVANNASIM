using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA191104SAVANNASIM;

namespace WFA191104SAVANNASIM
{
    public partial class FrmSavanna : Form
    {
        static Random rnd = new Random();
        Savanna savanna;
        public FrmSavanna(int s, int o)
        {
            InitializeComponent();
            savanna = new Savanna(s, o);
            Megjelenit();
        }

        private void Megjelenit()
        {
            for (int o = 0; o < savanna.Terulet.GetLength(0); o++)
            {
                for (int s = 0; s < savanna.Terulet.GetLength(1); s++)
                {
                    savanna.Terulet[o, s] = new PictureBox();
                    switch (rnd.Next(3))
                    {
                        case 0:
                            savanna.Terulet[o, s].Image = Properties.Resources.oroszlan;
                            break;
                        case 1:
                            savanna.Terulet[o, s].Image = Properties.Resources.gazella;
                            break;
                        case 2:
                            savanna.Terulet[o, s].Image = Properties.Resources.fu;
                            break;
                    }

                    savanna.Terulet[o, s].SetBounds(30 * o, 30 * s, 30, 30);
                    savanna.Terulet[o, s].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(savanna.Terulet[o, s]);
                }
                this.AutoSize = true;
            }
        }
    }
}
