using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        
        int px;
        int py;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            px = img_carro.Location.X;
            py = img_carro.Location.Y;

            px++;
            img_carro.Location = new Point(px, py);
            px = img_carro.Location.X;
           
        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            timercarro.Start();

        }

        private void bt_parar_Click(object sender, EventArgs e)
        {
            timercarro.Stop();
        }

    }
}
