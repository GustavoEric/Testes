using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace gol_show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                cmb1.Items.Add(s);
            }
        }
        string porta;


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = false;
            porta = cmb1.Text;
            this.Hide();
            Form2 tela2 = new Form2(porta);
            tela2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
