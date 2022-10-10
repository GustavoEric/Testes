using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gol_show
{
    public partial class Form3 : Form
    {
        string porta2;
        public Form3(int equipeV,int equipeA,string porta)
        {
            InitializeComponent();
            lblTimeAmarelo.Text = equipeA.ToString();
            lblTimeVerde.Text = equipeV.ToString();
            porta2 = porta;

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2(porta2);
            tela2.Show();
            Close();
        }
    }
}
