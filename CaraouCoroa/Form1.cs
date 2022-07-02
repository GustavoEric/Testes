using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaraouCoroa
{
    public partial class Form1 : Form
    {
        public static int aplauso = 0;
        public static int venceu = 0;
        public static int derrotas = 0;
        public static bool ganhou = false;

        public Form1()
        {
            InitializeComponent();
            cmbTema.Items.Add("Azul");
            cmbTema.Items.Add("Amarelo");
            cmbTema.Items.Add("Vermelho");
            cmbTema.Items.Add("Preto");
            cmbTema.Items.Add("Branco");            
        }
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            label1.Text = "Você";
            label2.Text = "Computador";
            if(rdbCoroa.Checked==false && rdbCara.Checked == false)
            {
                MessageBox.Show("Por Favor Escolha um das Opções");
            }
            //Sortear Numero
            Random rdm = new Random();
            int escolha = rdm.Next(0, 2);

            if (escolha==0 && rdbCara.Checked==true){
                ganhou = true;
                venceu += 1;
                aplauso += 1;
                //vitoria
                //reproduzir audio
                label1.Text = "Vencedor";
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("acerto.wav");
                sp.Play();
            }
            else if (escolha ==1 && rdbCoroa.Checked == true)
            {
                ganhou = true;
                venceu += 1;
                aplauso += 1;
                //vitoria
                label1.Text = "Vencedor";
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("acerto.wav");
                sp.Play();
            }
            else if (escolha==0 && rdbCoroa.Checked==true)
            {
                ganhou = false;
                derrotas += 1;
                //derrota
                label2.Text = "Vencedor";
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("erro.wav");
                sp.Play();
            }
            else if (escolha == 1 && rdbCara.Checked == true)
            {
                ganhou = false;
                derrotas += 1;
                //derrota
                label2.Text = "Vencedor";
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("erro.wav");
                sp.Play();
            }
            if (aplauso == 3 && ganhou == true)
            {
                aplauso = 0;
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("aplauso.wav");
                sp.Play();
            }
            label4.Text = (""+venceu);
            label6.Text = (""+derrotas);
        }

        private void rdbCara_CheckedChanged(object sender, EventArgs e)
        {
            ptbMoeda.Image = CaraouCoroa.Properties.Resources.cara;
            ptbComputador.Image = CaraouCoroa.Properties.Resources.coroa;
        }

        private void rdbCoroa_CheckedChanged(object sender, EventArgs e)
        {
            ptbMoeda.Image = CaraouCoroa.Properties.Resources.coroa;
            ptbComputador.Image = CaraouCoroa.Properties.Resources.cara;
        }

        private void btnZera_Click(object sender, EventArgs e)
        {
            ptbMoeda.Image = null;
            ptbComputador.Image = null;
            derrotas = 0;
            venceu = 0;
            label3.Text = ("Vitórias: ");
            label5.Text = ("Derrotas: ");
            label4.Text = ("" + venceu);
            label6.Text = ("" + derrotas);
            rdbCara.Checked = false;
            rdbCoroa.Checked = false;
        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (cmbTema.Text == "Azul")
            {
                this.BackColor = Color.Blue;
            }
            else if (cmbTema.Text == "Amarelo")
            {
                this.BackColor = Color.Yellow;
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.Black;
                    if (controle is RadioButton) controle.ForeColor = Color.Black;
                }
            }
            else if (cmbTema.Text == "Vermelho")
            {
                this.BackColor = Color.Red;
            }
            else if (cmbTema.Text == "Preto")
            {
                this.BackColor = Color.Black;

                //trocar cor de todos os componentes
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.White;
                    if (controle is RadioButton) controle.ForeColor = Color.White;
                }
            }
            else if (cmbTema.Text == "Branco")
            {
                this.BackColor = Color.White;
                foreach (Control controle in this.Controls)
                {
                    if (controle is Label) controle.ForeColor = Color.Black;
                    if (controle is RadioButton) controle.ForeColor = Color.Black;
                }
            }
            else
            {
                MessageBox.Show("Escolha uma das Opções");
            }
        }
    }
}
