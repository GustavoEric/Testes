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
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography;
using System.Media;
using System.Data.SQLite;

namespace gol_show
{
    public partial class Form2 : Form
    {
        SoundPlayer sp;
        Random rdm = new Random();

        
        internal class Conexao
        {
            //SqlConnection con = new SqlConnection(
            //    @"Data Source = DESKTOP-VNS7CO5;
            //Initial Catalog = dbGolshow;
            //Integrated Security = True;"
            //    );
            static string caminhoBD = Application.StartupPath;


            SQLiteConnection con = new SQLiteConnection("Data Source=" + caminhoBD + "\\DBGoShow.db");

            public SQLiteConnection Conectar()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

            public void Desconectar()
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        //Declaração de Variaveis
        ArrayList perguntas = new ArrayList();
        ArrayList alternativas = new ArrayList();
        List<int> numeros = new List<int>();
        public int pergunta = 1;
        public string txtAltCerta;
        public int x = 1;
        public int numeroPergunta=1;
        string letra;
        public string letractl;
        string a, b, c, d, altE,equipe;
        bool correto;
        int escolhePergunta;
        int equipeV=0, equipeA=0;
        int escolher;
        int quantidade = 22;

        public void altCorreta(int cod)
        {


            Conexao con = new Conexao();
            SQLiteCommand  da = new SQLiteCommand("SELECT * FROM tbAlternativa WHERE codPergunta = @COD and correta = 1", con.Conectar());

            da.Parameters.AddWithValue("@COD", cod);
            SQLiteDataReader rdr = da.ExecuteReader();

            while (rdr.Read())
            {
                txtAltCerta = rdr[2].ToString();
            }
        }
        public void consultarPerguntas() {
            Conexao con = new Conexao();
            SQLiteCommand  da = new SQLiteCommand ("SELECT * FROM tbPergunta", con.Conectar());
            SQLiteDataReader rdr = da.ExecuteReader();

            while (rdr.Read())
                {
                    perguntas.Add (rdr[1].ToString());
                }
        }

        public void Atualizar()
        {
            numeroPergunta += 1;
            btnAmarelo.BackColor = Color.Yellow;
            btnVerde.BackColor = Color.Green;
            btnAtl.BackColor = Color.Transparent;
            escolhePergunta = rdm.Next(0, quantidade);
            foreach (int lista in numeros)
            {
                while (escolhePergunta == lista)
                {
                    escolhePergunta = rdm.Next(0, quantidade);
                }
            }
            numeros.Add(escolhePergunta);

            if (equipe != "") { 
                if (equipe=="Verde" && correto == true)
                {
                    equipeV += 1;
                    btnVerde.Text=equipeV.ToString();

                }
                else if (equipe == "Amarelo" && correto == true)
                {
                    equipeA += 1;
                    btnAmarelo.Text = equipeA.ToString();

                }
                equipe = "";
                correto = false;
                x += 1;
                pergunta = escolhePergunta+1;
                altCorreta(pergunta);
                alternativas.Clear();
                consultarAlternativas(pergunta);
                embaralhar(alternativas);
                if (x>= 6)
                {
                    Form3 tela3 = new Form3(equipeV, equipeA,serialPort1.PortName);
                    tela3.Show();
                    Close();
                }
                else
                {
                    for (int i = 0; i <= alternativas.Count; i++)
                    {
                        //MessageBox.Show(alternativas[i].ToString());

                        if (i == 0)
                        {
                            lblA.Text = "A - " + alternativas[i].ToString();
                            a = alternativas[i].ToString();
                        }
                        else if (i == 1)
                        {
                            lblB.Text = "B - " + alternativas[i].ToString();
                            b = alternativas[i].ToString();
                        }
                        else if (i == 2)
                        {
                            lblC.Text = "C - " + alternativas[i].ToString();
                            c = alternativas[i].ToString();
                        }
                        else if (i == 3)
                        {
                            lblD.Text = "D - " + alternativas[i].ToString();
                            d = alternativas[i].ToString();
                        }
                        else if (i == 4)
                        {
                            lblE.Text = "E - " + alternativas[i].ToString();
                            altE = alternativas[i].ToString();
                        }
                    }


                    lblPergunta.Text = numeroPergunta + "- " + perguntas[escolhePergunta].ToString();
                }
            }
            else
            {
                MessageBox.Show("Escolha uma das Equipes");
            }
        }
        public void embaralhar(ArrayList lista)
        {
            // cria um objeto da classe Random
            Random rnd = new Random();

            // vamos embaralhar o ArrayList
            for (int i = 0; i < lista.Count; i++)
            {
                int a = rnd.Next(lista.Count);
                object temp = lista[i];
                lista[i] = lista[a];
                lista[a] = temp;
            }
        }


        public void consultarAlternativas(int cod)
        {
            Conexao con = new Conexao();
            SQLiteCommand  da = new SQLiteCommand ("SELECT * FROM tbAlternativa WHERE codPergunta = @COD", con.Conectar());
            da.Parameters.AddWithValue("@COD",cod);
            SQLiteDataReader rdr = da.ExecuteReader();

            while (rdr.Read())
            {


                alternativas.Add(rdr[2].ToString());
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string porta)
        {
            InitializeComponent();
            serialPort1.PortName = porta;

        }

        private void lblE_Click(object sender, EventArgs e)
        {
            letractl = altE;
            if (letractl == txtAltCerta)
            {
                musicaAcerto();
                correto = true;
                Atualizar();

            }
            else
            {
                musicaErro();
            }
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            letractl = c;
            if (letractl == txtAltCerta)
            {
                musicaAcerto();
                correto = true;
                Atualizar();

            }
            else
            {
                musicaErro();
            }
        }

        private void lblA_Click(object sender, EventArgs e)
        {
            letractl = a;
            if (letractl == txtAltCerta)
            {
                musicaAcerto();
                correto = true;
                Atualizar();

            }
            else
            {
                musicaErro();
            }
        }

        private void btnAmarelo_Click(object sender, EventArgs e)
        {
            equipe = "Amarelo";
            btnAmarelo.BackColor = Color.Yellow;
            btnVerde.BackColor = Color.LightGreen;
            btnAtl.BackColor = Color.Yellow;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            equipe = "Verde";
            btnVerde.BackColor = Color.LightGreen;
            btnAmarelo.BackColor = Color.LightYellow;
            btnAtl.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer("brasil.wav");
            sp.Play();
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            consultarPerguntas();
            escolhePergunta = rdm.Next(0,quantidade);
            foreach(int lista in numeros)
            {
                while (escolhePergunta == lista)
                {
                    escolhePergunta = rdm.Next(0,quantidade);
                }
            }
            numeros.Add(escolhePergunta);
            pergunta = escolhePergunta + 1;
            altCorreta(pergunta);
            consultarAlternativas(pergunta);
            lblPergunta.Text = numeroPergunta+"- "+perguntas[escolhePergunta].ToString();
            embaralhar(alternativas);

            for (int i = 0; i <= alternativas.Count; i++)
            {
                //MessageBox.Show(alternativas[i].ToString());

                if (i == 0)
                {
                    lblA.Text = "A - "+alternativas[i].ToString();
                    a = alternativas[i].ToString();
                }
                else if (i == 1)
                {
                    lblB.Text = "B - "+alternativas[i].ToString();
                    b = alternativas[i].ToString();
                }
                else if (i == 2)
                {
                    lblC.Text = "C - " + alternativas[i].ToString();
                    c = alternativas[i].ToString();
                }
                else if (i == 3)
                {
                    lblD.Text = "D - " + alternativas[i].ToString();
                    d= alternativas[i].ToString();
                }
                else if (i == 4)
                {
                    lblE.Text = "E - " + alternativas[i].ToString();
                    altE = alternativas[i].ToString();
                }
            }

            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.Open();
                    panel1.BackColor = Color.Green;
                    letra = serialPort1.ReadExisting();


                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    letra = serialPort1.ReadExisting();
                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                }
                catch
                {
                    return;
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            letractl = b;
            if (letractl == txtAltCerta)
            {
                musicaAcerto();
                correto = true;
                Atualizar();

            }
            else
            {
                musicaErro();
            }
        }
        public void musicaErro()
        {
            escolher = rdm.Next(1, 4);
            if (escolher == 1) { 
                sp = new SoundPlayer("epa.wav");
                sp.Play();
            }
            else if (escolher == 2)
            {
                sp = new SoundPlayer("brincadeira.wav");
                sp.Play();
            }
            else if (escolher == 3)
            {
                sp = new SoundPlayer("nao.wav");
                sp.Play();
            }
        }
        public void musicaAcerto()
        {
            escolher = rdm.Next(1, 3);
            if (escolher == 1)
            {
                sp = new SoundPlayer("demais.wav");
                sp.Play();
            }
            else if (escolher == 2)
            {
                sp = new SoundPlayer("ira.wav");
                sp.Play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            letra = serialPort1.ReadExisting();
            if (letra != null && equipe !=null)
            {
                if (letra == "A")
                {
                    if (a == txtAltCerta)
                    {
                        musicaAcerto();
                        correto = true;
                        Atualizar();

                    }
                    else
                    {
                        musicaErro();
                    }
                }
                else if (letra == "B")
                {
                    if (b == txtAltCerta)
                    {
                        musicaAcerto();
                        correto = true;
                        Atualizar();
                    }
                    else
                    {
                        musicaErro();
                    }
                }
                else if (letra == "C")
                {
                    if (c == txtAltCerta)
                    {
                        musicaAcerto();
                        correto = true;
                        Atualizar();
                    }
                    else
                    {
                        musicaErro();
                    }
                }
                else if (letra == "D")
                {
                    if (d == txtAltCerta)
                    {
                        musicaAcerto();
                        correto = true;
                        Atualizar();
                    }
                    else
                    {
                        musicaErro();
                    }
                }
                else if (letra == "E")
                {
                    if (altE == txtAltCerta)
                    {
                        musicaAcerto();
                        correto = true;
                        Atualizar();
                    }
                    else
                    {
                        musicaErro();
                    }
                }


            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            letractl = d;
            if (letractl == txtAltCerta)
            {
                musicaAcerto();
                correto = true;
                Atualizar();

            }
            else
            {
                musicaErro();
            }
        }
    }
}
