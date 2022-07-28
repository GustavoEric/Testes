using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula11
{
    public partial class Form1 : Form
    {
        int contFrutas = 0;
        int tempoT = 0;
        int tempoComer = 0;
        int vidaPac = 3;
        // int altura;
        //int a = 0;
        bool podeComer = false;
        bool esq = false,dir=false,cima=false,baixo=false;
        int tempo = 0;
        int velocidadeF = 1;
        int distanciaT;
        int distanciaL;
        //Timer de Seguir
        int contador = 0;
        bool F1seguir = false;
        bool F2seguir = false;
        bool F3seguir = false;
        bool F4seguir = false;
        bool comecar = false;

        int pontos=0;

        //Bool fantasma1
        bool pcbF1Cima = false;
        bool pcbF1Baixo = false;
        bool pcbF1Esq = false;
        bool pcbF1Dir = false;
        //Bool fantasma2
        bool pcbF2Cima = false;
        bool pcbF2Baixo = false;
        bool pcbF2Esq = false;
        bool pcbF2Dir = false;
        //Bool fantasma3
        bool pcbF3Cima = false;
        bool pcbF3Baixo = false;
        bool pcbF3Esq = false;
        bool pcbF3Dir = false;
        //Bool fantasma4
        bool pcbF4Cima = false;
        bool pcbF4Baixo = false;
        bool pcbF4Esq = false;
        bool pcbF4Dir = false;
        Random rdn = new Random();


        public Form1()
        {
            InitializeComponent();
        }
        public void MovimentoF(int posicaoL, int posicaoT,int fantasma)
        {
            distanciaL = pcbPacMan.Left - posicaoL;
            distanciaT = pcbPacMan.Top - posicaoT;
            //Movimento Fantasma 1

            //Apenas Esq
            if ((posicaoL == pnt47.Left && posicaoT == pnt47.Top) && (fantasma == 1)){
                pcbF1Esq = true;
                pcbF1Cima = false;
                pcbF1Baixo = false;
                pcbF1Dir = false;
            }
            //Apenas Dir
            if ((posicaoL == pnt40.Left && posicaoT == pnt40.Top) && (fantasma == 1))
            {
                pcbF1Dir = true;
                pcbF1Cima = false;
                pcbF1Baixo = false;
                pcbF1Esq = false;
            }
            //Dir,Baix,Cim
            if (((posicaoL == pnt7.Left && posicaoT == pnt7.Top) && (fantasma == 1)) || ((posicaoL == pnt17.Left && posicaoT == pnt17.Top) && (fantasma == 1)) 
                || ((posicaoL == pnt19.Left && posicaoT == pnt19.Top) && (fantasma == 1)) || ((posicaoL == pnt23.Left && posicaoT == pnt23.Top) && (fantasma == 1)) 
                || ((posicaoL == pnt36.Left && posicaoT == pnt36.Top) && (fantasma == 1)))
            {
                    int escolha = rdn.Next(0, 3);
                    if (escolha == 1)
                    {
                        pcbF1Dir = true;
                        pcbF1Cima = false;
                        pcbF1Baixo = false;
                        pcbF1Esq = false;
                    }
                    else if (escolha==2)
                    {
                        pcbF1Baixo = true;
                        pcbF1Cima = false;
                        pcbF1Dir = false;
                        pcbF1Esq = false;
                    }
                    else
                    {
                        pcbF1Cima = true;
                        pcbF1Baixo = false;
                        pcbF1Dir = false;
                        pcbF1Esq = false;
                    }
            }
            //Esq,Baix
            if (((posicaoL == pnt3.Left && posicaoT == pnt3.Top) && (fantasma == 1)) || ((posicaoL == pnt6.Left && posicaoT == pnt6.Top) && (fantasma == 1))
               || ((posicaoL == pnt28.Left && posicaoT == pnt28.Top) && (fantasma == 1)) || ((posicaoL == pnt33.Left && posicaoT == pnt33.Top) && (fantasma == 1))
               || ((posicaoL == pnt35.Left && posicaoT == pnt35.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else
                {
                    pcbF1Baixo = true;
                    pcbF1Cima = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Dir,Baix
            if (((posicaoL == pnt1.Left && posicaoT == pnt1.Top) && (fantasma == 1)) || ((posicaoL == pnt4.Left && posicaoT == pnt4.Top) && (fantasma == 1))
               || ((posicaoL == pnt24.Left && posicaoT == pnt24.Top) && (fantasma == 1)) || ((posicaoL == pnt29.Left && posicaoT == pnt29.Top) && (fantasma == 1))
               || ((posicaoL == pnt38.Left && posicaoT == pnt38.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Baixo = true;
                    pcbF1Cima = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Dir,Baix
            if (((posicaoL == pnt2.Left && posicaoT == pnt2.Top) && (fantasma == 1)) || ((posicaoL == pnt5.Left && posicaoT == pnt5.Top) && (fantasma == 1))
               || ((posicaoL == pnt9.Left && posicaoT == pnt9.Top) && (fantasma == 1)) || ((posicaoL == pnt12.Left && posicaoT == pnt12.Top) && (fantasma == 1))
               || ((posicaoL == pnt26.Left && posicaoT == pnt26.Top) && (fantasma == 1)) || ((posicaoL == pnt31.Left && posicaoT == pnt31.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Baixo = true;
                    pcbF1Cima = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Dir,Cim
            if (((posicaoL == pnt11.Left && posicaoT == pnt11.Top) && (fantasma == 1)) || ((posicaoL == pnt25.Left && posicaoT == pnt25.Top) && (fantasma == 1))
               || ((posicaoL == pnt27.Left && posicaoT == pnt27.Top) && (fantasma == 1)) || ((posicaoL == pnt30.Left && posicaoT == pnt30.Top) && (fantasma == 1))
               || ((posicaoL == pnt32.Left && posicaoT == pnt32.Top) && (fantasma == 1)) || ((posicaoL == pnt41.Left && posicaoT == pnt41.Top) && (fantasma == 1))
               || ((posicaoL == pnt42.Left && posicaoT == pnt42.Top) && (fantasma == 1)) || ((posicaoL == pnt45.Left && posicaoT == pnt45.Top) && (fantasma == 1))||
               ((posicaoL == pnt46.Left && posicaoT == pnt46.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Cima = true;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Dir
            if (((posicaoL == pnt10.Left && posicaoT == pnt10.Top) && (fantasma == 1)) || ((posicaoL == pnt20.Left && posicaoT == pnt20.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Cim
            if (((posicaoL == pnt18.Left && posicaoT == pnt18.Top) && (fantasma == 1)) || ((posicaoL == pnt39.Left && posicaoT == pnt39.Top) && (fantasma == 1))
                || ((posicaoL == pnt43.Left && posicaoT == pnt43.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else
                {
                    pcbF1Cima = true;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Dir,Cim
            if (((posicaoL == pnt15.Left && posicaoT == pnt15.Top) && (fantasma == 1)) || ((posicaoL == pnt34.Left && posicaoT == pnt34.Top) && (fantasma == 1))
                || ((posicaoL == pnt44.Left && posicaoT == pnt44.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Cima = true;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Dir,Baix,Cim
            if (((posicaoL == pnt8.Left && posicaoT == pnt8.Top) && (fantasma == 1)) || ((posicaoL == pnt13.Left && posicaoT == pnt13.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 4);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF1Dir = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Esq = false;
                }
                else if (escolha == 3)
                {
                    pcbF1Baixo = true;
                    pcbF1Cima = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Cima = true;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Esq,Baix,Cim
            if (((posicaoL == pnt14.Left && posicaoT == pnt14.Top) && (fantasma == 1)) || ((posicaoL == pnt16.Left && posicaoT == pnt16.Top) && (fantasma == 1))
               || ((posicaoL == pnt21.Left && posicaoT == pnt21.Top) && (fantasma == 1)) || ((posicaoL == pnt22.Left && posicaoT == pnt22.Top) && (fantasma == 1))
               || ((posicaoL == pnt37.Left && posicaoT == pnt37.Top) && (fantasma == 1)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF1Esq = true;
                    pcbF1Cima = false;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF1Baixo = true;
                    pcbF1Cima = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
                else
                {
                    pcbF1Cima = true;
                    pcbF1Baixo = false;
                    pcbF1Dir = false;
                    pcbF1Esq = false;
                }
            }
            //Movimento Fantasma 2

            //Apenas Esq
            if ((posicaoL == pnt47.Left && posicaoT == pnt47.Top) && (fantasma == 2))
            {
                pcbF2Esq = true;
                pcbF2Cima = false;
                pcbF2Baixo = false;
                pcbF2Dir = false;
            }
            //Apenas Dir
            if ((posicaoL == pnt40.Left && posicaoT == pnt40.Top) && (fantasma == 2))
            {
                pcbF2Dir = true;
                pcbF2Cima = false;
                pcbF2Baixo = false;
                pcbF2Esq = false;
            }
            //Dir,Baix,Cim
            if (((posicaoL == pnt7.Left && posicaoT == pnt7.Top) && (fantasma == 2)) || ((posicaoL == pnt17.Left && posicaoT == pnt17.Top) && (fantasma == 2))
                || ((posicaoL == pnt19.Left && posicaoT == pnt19.Top) && (fantasma == 2)) || ((posicaoL == pnt23.Left && posicaoT == pnt23.Top) && (fantasma == 2))
                || ((posicaoL == pnt36.Left && posicaoT == pnt36.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else if (escolha == 2)
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Baix
            if (((posicaoL == pnt3.Left && posicaoT == pnt3.Top) && (fantasma == 2)) || ((posicaoL == pnt6.Left && posicaoT == pnt6.Top) && (fantasma == 2))
               || ((posicaoL == pnt28.Left && posicaoT == pnt28.Top) && (fantasma == 2)) || ((posicaoL == pnt33.Left && posicaoT == pnt33.Top) && (fantasma == 2))
               || ((posicaoL == pnt35.Left && posicaoT == pnt35.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Dir,Baix
            if (((posicaoL == pnt1.Left && posicaoT == pnt1.Top) && (fantasma == 2)) || ((posicaoL == pnt4.Left && posicaoT == pnt4.Top) && (fantasma == 2))
               || ((posicaoL == pnt24.Left && posicaoT == pnt24.Top) && (fantasma == 2)) || ((posicaoL == pnt29.Left && posicaoT == pnt29.Top) && (fantasma == 2))
               || ((posicaoL == pnt38.Left && posicaoT == pnt38.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Dir,Baix
            if (((posicaoL == pnt2.Left && posicaoT == pnt2.Top) && (fantasma == 2)) || ((posicaoL == pnt5.Left && posicaoT == pnt5.Top) && (fantasma == 2))
               || ((posicaoL == pnt9.Left && posicaoT == pnt9.Top) && (fantasma == 2)) || ((posicaoL == pnt12.Left && posicaoT == pnt12.Top) && (fantasma == 2))
               || ((posicaoL == pnt26.Left && posicaoT == pnt26.Top) && (fantasma == 2)) || ((posicaoL == pnt31.Left && posicaoT == pnt31.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Dir,Cim
            if (((posicaoL == pnt11.Left && posicaoT == pnt11.Top) && (fantasma == 2)) || ((posicaoL == pnt25.Left && posicaoT == pnt25.Top) && (fantasma == 2))
               || ((posicaoL == pnt27.Left && posicaoT == pnt27.Top) && (fantasma == 2)) || ((posicaoL == pnt30.Left && posicaoT == pnt30.Top) && (fantasma == 2))
               || ((posicaoL == pnt32.Left && posicaoT == pnt32.Top) && (fantasma == 2)) || ((posicaoL == pnt41.Left && posicaoT == pnt41.Top) && (fantasma == 2))
               || ((posicaoL == pnt42.Left && posicaoT == pnt42.Top) && (fantasma == 2)) || ((posicaoL == pnt45.Left && posicaoT == pnt45.Top) && (fantasma == 2)) ||
               ((posicaoL == pnt46.Left && posicaoT == pnt46.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Dir
            if (((posicaoL == pnt10.Left && posicaoT == pnt10.Top) && (fantasma == 2)) || ((posicaoL == pnt20.Left && posicaoT == pnt20.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Cim
            if (((posicaoL == pnt18.Left && posicaoT == pnt18.Top) && (fantasma == 2)) || ((posicaoL == pnt39.Left && posicaoT == pnt39.Top) && (fantasma == 2))
                || ((posicaoL == pnt43.Left && posicaoT == pnt43.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Dir,Cim
            if (((posicaoL == pnt15.Left && posicaoT == pnt15.Top) && (fantasma == 2)) || ((posicaoL == pnt34.Left && posicaoT == pnt34.Top) && (fantasma == 2))
                || ((posicaoL == pnt44.Left && posicaoT == pnt44.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Dir,Baix,Cim
            if (((posicaoL == pnt8.Left && posicaoT == pnt8.Top) && (fantasma == 2)) || ((posicaoL == pnt13.Left && posicaoT == pnt13.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 4);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF2Dir = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Esq = false;
                }
                else if (escolha == 3)
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Esq,Baix,Cim
            if (((posicaoL == pnt14.Left && posicaoT == pnt14.Top) && (fantasma == 2)) || ((posicaoL == pnt16.Left && posicaoT == pnt16.Top) && (fantasma == 2))
               || ((posicaoL == pnt21.Left && posicaoT == pnt21.Top) && (fantasma == 2)) || ((posicaoL == pnt22.Left && posicaoT == pnt22.Top) && (fantasma == 2))
               || ((posicaoL == pnt37.Left && posicaoT == pnt37.Top) && (fantasma == 2)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF2Esq = true;
                    pcbF2Cima = false;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF2Baixo = true;
                    pcbF2Cima = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
                else
                {
                    pcbF2Cima = true;
                    pcbF2Baixo = false;
                    pcbF2Dir = false;
                    pcbF2Esq = false;
                }
            }
            //Movimento Fantasma 3

            //Apenas Esq
            if ((posicaoL == pnt47.Left && posicaoT == pnt47.Top) && (fantasma == 3))
            {
                pcbF3Esq = true;
                pcbF3Cima = false;
                pcbF3Baixo = false;
                pcbF3Dir = false;
            }
            //Apenas Dir
            if ((posicaoL == pnt40.Left && posicaoT == pnt40.Top) && (fantasma == 3))
            {
                pcbF3Dir = true;
                pcbF3Cima = false;
                pcbF3Baixo = false;
                pcbF3Esq = false;
            }
            //Dir,Baix,Cim
            if (((posicaoL == pnt7.Left && posicaoT == pnt7.Top) && (fantasma == 3)) || ((posicaoL == pnt17.Left && posicaoT == pnt17.Top) && (fantasma == 3))
                || ((posicaoL == pnt19.Left && posicaoT == pnt19.Top) && (fantasma == 3)) || ((posicaoL == pnt23.Left && posicaoT == pnt23.Top) && (fantasma == 3))
                || ((posicaoL == pnt36.Left && posicaoT == pnt36.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else if (escolha == 2)
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Baix
            if (((posicaoL == pnt3.Left && posicaoT == pnt3.Top) && (fantasma == 3)) || ((posicaoL == pnt6.Left && posicaoT == pnt6.Top) && (fantasma == 3))
               || ((posicaoL == pnt28.Left && posicaoT == pnt28.Top) && (fantasma == 3)) || ((posicaoL == pnt33.Left && posicaoT == pnt33.Top) && (fantasma == 3))
               || ((posicaoL == pnt35.Left && posicaoT == pnt35.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Dir,Baix
            if (((posicaoL == pnt1.Left && posicaoT == pnt1.Top) && (fantasma == 3)) || ((posicaoL == pnt4.Left && posicaoT == pnt4.Top) && (fantasma == 3))
               || ((posicaoL == pnt24.Left && posicaoT == pnt24.Top) && (fantasma == 3)) || ((posicaoL == pnt29.Left && posicaoT == pnt29.Top) && (fantasma == 3))
               || ((posicaoL == pnt38.Left && posicaoT == pnt38.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Dir,Baix
            if (((posicaoL == pnt2.Left && posicaoT == pnt2.Top) && (fantasma == 3)) || ((posicaoL == pnt5.Left && posicaoT == pnt5.Top) && (fantasma == 3))
               || ((posicaoL == pnt9.Left && posicaoT == pnt9.Top) && (fantasma == 3)) || ((posicaoL == pnt12.Left && posicaoT == pnt12.Top) && (fantasma == 3))
               || ((posicaoL == pnt26.Left && posicaoT == pnt26.Top) && (fantasma == 3)) || ((posicaoL == pnt31.Left && posicaoT == pnt31.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Dir,Cim
            if (((posicaoL == pnt11.Left && posicaoT == pnt11.Top) && (fantasma == 3)) || ((posicaoL == pnt25.Left && posicaoT == pnt25.Top) && (fantasma == 3))
               || ((posicaoL == pnt27.Left && posicaoT == pnt27.Top) && (fantasma == 3)) || ((posicaoL == pnt30.Left && posicaoT == pnt30.Top) && (fantasma == 3))
               || ((posicaoL == pnt32.Left && posicaoT == pnt32.Top) && (fantasma == 3)) || ((posicaoL == pnt41.Left && posicaoT == pnt41.Top) && (fantasma == 3))
               || ((posicaoL == pnt42.Left && posicaoT == pnt42.Top) && (fantasma == 3)) || ((posicaoL == pnt45.Left && posicaoT == pnt45.Top) && (fantasma == 3)) ||
               ((posicaoL == pnt46.Left && posicaoT == pnt46.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Dir
            if (((posicaoL == pnt10.Left && posicaoT == pnt10.Top) && (fantasma == 3)) || ((posicaoL == pnt20.Left && posicaoT == pnt20.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Cim
            if (((posicaoL == pnt18.Left && posicaoT == pnt18.Top) && (fantasma == 3)) || ((posicaoL == pnt39.Left && posicaoT == pnt39.Top) && (fantasma == 3))
                || ((posicaoL == pnt43.Left && posicaoT == pnt43.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Dir,Cim
            if (((posicaoL == pnt15.Left && posicaoT == pnt15.Top) && (fantasma == 3)) || ((posicaoL == pnt34.Left && posicaoT == pnt34.Top) && (fantasma == 3))
                || ((posicaoL == pnt44.Left && posicaoT == pnt44.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Dir,Baix,Cim
            if (((posicaoL == pnt8.Left && posicaoT == pnt8.Top) && (fantasma == 3)) || ((posicaoL == pnt13.Left && posicaoT == pnt13.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 4);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF3Dir = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Esq = false;
                }
                else if (escolha == 3)
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Esq,Baix,Cim
            if (((posicaoL == pnt14.Left && posicaoT == pnt14.Top) && (fantasma == 3)) || ((posicaoL == pnt16.Left && posicaoT == pnt16.Top) && (fantasma == 3))
               || ((posicaoL == pnt21.Left && posicaoT == pnt21.Top) && (fantasma == 3)) || ((posicaoL == pnt22.Left && posicaoT == pnt22.Top) && (fantasma == 3))
               || ((posicaoL == pnt37.Left && posicaoT == pnt37.Top) && (fantasma == 3)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF3Esq = true;
                    pcbF3Cima = false;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF3Baixo = true;
                    pcbF3Cima = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
                else
                {
                    pcbF3Cima = true;
                    pcbF3Baixo = false;
                    pcbF3Dir = false;
                    pcbF3Esq = false;
                }
            }
            //Movimento Fantasma 4

            //Apenas Esq
            if ((posicaoL == pnt47.Left && posicaoT == pnt47.Top) && (fantasma == 4))
            {
                pcbF4Esq = true;
                pcbF4Cima = false;
                pcbF4Baixo = false;
                pcbF4Dir = false;
            }
            //Apenas Dir
            if ((posicaoL == pnt40.Left && posicaoT == pnt40.Top) && (fantasma == 4))
            {
                pcbF4Dir = true;
                pcbF4Cima = false;
                pcbF4Baixo = false;
                pcbF4Esq = false;
            }
            //Dir,Baix,Cim
            if (((posicaoL == pnt7.Left && posicaoT == pnt7.Top) && (fantasma == 4)) || ((posicaoL == pnt17.Left && posicaoT == pnt17.Top) && (fantasma == 4))
                || ((posicaoL == pnt19.Left && posicaoT == pnt19.Top) && (fantasma == 4)) || ((posicaoL == pnt23.Left && posicaoT == pnt23.Top) && (fantasma == 4))
                || ((posicaoL == pnt36.Left && posicaoT == pnt36.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else if (escolha == 2)
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Baix
            if (((posicaoL == pnt3.Left && posicaoT == pnt3.Top) && (fantasma == 4)) || ((posicaoL == pnt6.Left && posicaoT == pnt6.Top) && (fantasma == 4))
               || ((posicaoL == pnt28.Left && posicaoT == pnt28.Top) && (fantasma == 4)) || ((posicaoL == pnt33.Left && posicaoT == pnt33.Top) && (fantasma == 4))
               || ((posicaoL == pnt35.Left && posicaoT == pnt35.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Dir,Baix
            if (((posicaoL == pnt1.Left && posicaoT == pnt1.Top) && (fantasma == 4)) || ((posicaoL == pnt4.Left && posicaoT == pnt4.Top) && (fantasma == 4))
               || ((posicaoL == pnt24.Left && posicaoT == pnt24.Top) && (fantasma == 4)) || ((posicaoL == pnt29.Left && posicaoT == pnt29.Top) && (fantasma == 4))
               || ((posicaoL == pnt38.Left && posicaoT == pnt38.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Dir,Baix
            if (((posicaoL == pnt2.Left && posicaoT == pnt2.Top) && (fantasma == 4)) || ((posicaoL == pnt5.Left && posicaoT == pnt5.Top) && (fantasma == 4))
               || ((posicaoL == pnt9.Left && posicaoT == pnt9.Top) && (fantasma == 4)) || ((posicaoL == pnt12.Left && posicaoT == pnt12.Top) && (fantasma == 4))
               || ((posicaoL == pnt26.Left && posicaoT == pnt26.Top) && (fantasma == 4)) || ((posicaoL == pnt31.Left && posicaoT == pnt31.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Dir,Cim
            if (((posicaoL == pnt11.Left && posicaoT == pnt11.Top) && (fantasma == 4)) || ((posicaoL == pnt25.Left && posicaoT == pnt25.Top) && (fantasma == 4))
               || ((posicaoL == pnt27.Left && posicaoT == pnt27.Top) && (fantasma == 4)) || ((posicaoL == pnt30.Left && posicaoT == pnt30.Top) && (fantasma == 4))
               || ((posicaoL == pnt32.Left && posicaoT == pnt32.Top) && (fantasma == 4)) || ((posicaoL == pnt41.Left && posicaoT == pnt41.Top) && (fantasma == 4))
               || ((posicaoL == pnt42.Left && posicaoT == pnt42.Top) && (fantasma == 4)) || ((posicaoL == pnt45.Left && posicaoT == pnt45.Top) && (fantasma == 4)) ||
               ((posicaoL == pnt46.Left && posicaoT == pnt46.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Dir
            if (((posicaoL == pnt10.Left && posicaoT == pnt10.Top) && (fantasma == 4)) || ((posicaoL == pnt20.Left && posicaoT == pnt20.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Cim
            if (((posicaoL == pnt18.Left && posicaoT == pnt18.Top) && (fantasma == 4)) || ((posicaoL == pnt39.Left && posicaoT == pnt39.Top) && (fantasma == 4))
                || ((posicaoL == pnt43.Left && posicaoT == pnt43.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Dir,Cim
            if (((posicaoL == pnt15.Left && posicaoT == pnt15.Top) && (fantasma == 4)) || ((posicaoL == pnt34.Left && posicaoT == pnt34.Top) && (fantasma == 4))
                || ((posicaoL == pnt44.Left && posicaoT == pnt44.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 2);
                if (escolha == 1)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Dir,Baix,Cim
            if (((posicaoL == pnt8.Left && posicaoT == pnt8.Top) && (fantasma == 4)) || ((posicaoL == pnt13.Left && posicaoT == pnt13.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 4);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF4Dir = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Esq = false;
                }
                else if (escolha == 3)
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Esq,Baix,Cim
            if (((posicaoL == pnt14.Left && posicaoT == pnt14.Top) && (fantasma == 4)) || ((posicaoL == pnt16.Left && posicaoT == pnt16.Top) && (fantasma == 4))
               || ((posicaoL == pnt21.Left && posicaoT == pnt21.Top) && (fantasma == 4)) || ((posicaoL == pnt22.Left && posicaoT == pnt22.Top) && (fantasma == 4))
               || ((posicaoL == pnt37.Left && posicaoT == pnt37.Top) && (fantasma == 4)))
            {
                int escolha = rdn.Next(0, 3);
                if (escolha == 1)
                {
                    pcbF4Esq = true;
                    pcbF4Cima = false;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                }
                else if (escolha == 2)
                {
                    pcbF4Baixo = true;
                    pcbF4Cima = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
                else
                {
                    pcbF4Cima = true;
                    pcbF4Baixo = false;
                    pcbF4Dir = false;
                    pcbF4Esq = false;
                }
            }
            //Movimentação Inicio
            if ((posicaoL == pntInicio.Left && posicaoT == pntInicio.Top) && (fantasma == 1)){
                pcbF1Cima = true;
                pcbF1Baixo = false;
                pcbF1Dir = false;
                pcbF1Esq = false;
            }
            if ((posicaoL == pntInicio.Left && posicaoT == pntInicio.Top) && (fantasma == 2))
            {
                pcbF2Cima = true;
                pcbF2Baixo = false;
                pcbF2Dir = false;
                pcbF2Esq = false;
            }
            if ((posicaoL == pntInicio.Left && posicaoT == pntInicio.Top) && (fantasma == 3))
            {
                pcbF3Cima = true;
                pcbF3Baixo = false;
                pcbF3Dir = false;
                pcbF3Esq = false;
            }
            if ((posicaoL == pntInicio.Left && posicaoT == pntInicio.Top) && (fantasma == 4))
            {
                pcbF4Cima = true;
                pcbF4Baixo = false;
                pcbF4Dir = false;
                pcbF4Esq = false;
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        private void timerF_Tick(object sender, EventArgs e)
        {
            if (comecar == true && F1seguir == true){ 
            //Fantasma 1
            MovimentoF(pcbF1.Left, pcbF1.Top, 1);
                if (pcbF1Esq == true)
                {
                    pcbF1.Left -= velocidadeF;
                    MovimentoF(pcbF1.Left, pcbF1.Top, 1);
                }
                if (pcbF1Dir == true)
                {
                    pcbF1.Left += velocidadeF;
                    MovimentoF(pcbF1.Left, pcbF1.Top, 1);
                }
                if (pcbF1Baixo == true)
                {
                    pcbF1.Top += velocidadeF;
                    MovimentoF(pcbF1.Left, pcbF1.Top, 1);
                }
                if (pcbF1Cima == true)
                {
                    pcbF1.Top -= velocidadeF;
                    MovimentoF(pcbF1.Left, pcbF1.Top, 1);
                }
                 MovimentoF(pcbF1.Left, pcbF1.Top, 1);

                if ((pcbF1.Bounds.IntersectsWith(pcbPacMan.Bounds)) && (podeComer==true))
                {
                    pcbF1.Left = pntInicio.Left;
                    pcbF1.Top = pntInicio.Top;
                }
                if ((pcbF1.Bounds.IntersectsWith(pcbPacMan.Bounds)) && (podeComer == false))
                {
                    vidaPac = vidaPac - 1;
                    derrota(vidaPac);
                }
                if (pcbF1.Left < 0)
                {
                    pcbF1.Left = 626;
                    pcbF1Esq = true;
                }
                else if (pcbF1.Left > 626)
                {
                    pcbF1.Left = 0;
                    pcbF1Dir = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmInicio.Start();
            pcbF1.Left = pntInicio.Left;
            pcbF2.Left = pntInicio.Left;
            pcbF3.Left = pntInicio.Left;
            pcbF4.Left = pntInicio.Left;
            pcbF1.Top = pntInicio.Top;
            pcbF2.Top = pntInicio.Top;
            pcbF3.Top = pntInicio.Top;
            pcbF4.Top = pntInicio.Top;
        }

        private void paredel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcbFruta1_Click(object sender, EventArgs e)
        {

        }

        private void pcbPacMan_Click(object sender, EventArgs e)
        {

        }

        private void panel64_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox126_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {

        }

        private void timerF2_Tick(object sender, EventArgs e)
        {
            if (comecar == true && F2seguir == true)
            {
                //Fantasma 2
                MovimentoF(pcbF2.Left, pcbF2.Top, 2);
                if (pcbF2Esq == true)
                {
                    pcbF2.Left -= velocidadeF;
                    MovimentoF(pcbF2.Left, pcbF2.Top, 2);
                }
                if (pcbF2Dir == true)
                {
                    pcbF2.Left += velocidadeF;
                    MovimentoF(pcbF2.Left, pcbF2.Top, 2);
                }
                if (pcbF2Baixo == true)
                {
                    pcbF2.Top += velocidadeF;
                    MovimentoF(pcbF2.Left, pcbF2.Top, 2);
                }
                if (pcbF2Cima == true)
                {
                    pcbF2.Top -= velocidadeF;
                    MovimentoF(pcbF2.Left, pcbF2.Top, 2);
                }
                MovimentoF(pcbF2.Left, pcbF2.Top, 2);

                if ((pcbF2.Bounds.IntersectsWith(pcbPacMan.Bounds))&&(podeComer==true))
                {
                    pcbF2.Left = pntInicio.Left;
                    pcbF2.Top = pntInicio.Top;
                }
                if ((pcbF2.Bounds.IntersectsWith(pcbPacMan.Bounds)) && (podeComer == false))
                {
                    vidaPac = vidaPac - 1;
                    derrota(vidaPac);
                }
                if (pcbF2.Left < 0)
                {
                    pcbF2.Left = 626;
                    pcbF2Esq = true;
                }
                else if (pcbF2.Left > 626)
                {
                    pcbF2.Left = 0;
                    pcbF2Dir = true;
                }
            }
        }

        private void timerF3_Tick(object sender, EventArgs e)
        {
            if (comecar == true && F3seguir == true)
            {
                //Fantasma 3
                MovimentoF(pcbF3.Left, pcbF3.Top, 3);
                if (pcbF3Esq == true)
                {
                    pcbF3.Left -= velocidadeF;
                    MovimentoF(pcbF3.Left, pcbF3.Top, 3);
                }
                if (pcbF3Dir == true)
                {
                    pcbF3.Left += velocidadeF;
                    MovimentoF(pcbF3.Left, pcbF3.Top, 3);
                }
                if (pcbF3Baixo == true)
                {
                    pcbF3.Top += velocidadeF;
                    MovimentoF(pcbF3.Left, pcbF3.Top, 3);
                }
                if (pcbF3Cima == true)
                {
                    pcbF3.Top -= velocidadeF;
                    MovimentoF(pcbF3.Left, pcbF3.Top, 3);
                }
                MovimentoF(pcbF3.Left, pcbF3.Top, 3);

                if ((pcbF3.Bounds.IntersectsWith(pcbPacMan.Bounds))&&(podeComer==true))
                {
                    pcbF3.Left = pntInicio.Left;
                    pcbF3.Top = pntInicio.Top;
                }
                if ((pcbF3.Bounds.IntersectsWith(pcbPacMan.Bounds)) && (podeComer == false))
                {
                    vidaPac = vidaPac - 1;
                    derrota(vidaPac);
                }
                if (pcbF3.Left < 0)
                {
                    pcbF3.Left = 626;
                    pcbF3Esq = true;
                }
                else if (pcbF3.Left > 626)
                {
                    pcbF3.Left = 0;
                    pcbF3Dir = true;
                }
            }
        }

        private void timerF4_Tick(object sender, EventArgs e)
        {
            if (comecar == true && F4seguir == true)
            {
                //Fantasma 4
                MovimentoF(pcbF4.Left, pcbF4.Top, 4);
                if (pcbF4Esq == true)
                {
                    pcbF4.Left -= velocidadeF;
                    MovimentoF(pcbF4.Left, pcbF4.Top, 4);
                }
                if (pcbF4Dir == true)
                {
                    pcbF4.Left += velocidadeF;
                    MovimentoF(pcbF4.Left, pcbF4.Top, 4);
                }
                if (pcbF4Baixo == true)
                {
                    pcbF4.Top += velocidadeF;
                    MovimentoF(pcbF4.Left, pcbF4.Top, 4);
                }
                if (pcbF4Cima == true)
                {
                    pcbF4.Top -= velocidadeF;
                    MovimentoF(pcbF4.Left, pcbF4.Top, 4);
                }
                MovimentoF(pcbF4.Left, pcbF4.Top, 4);

                if ((pcbF4.Bounds.IntersectsWith(pcbPacMan.Bounds))&&(podeComer==true))
                {
                    pcbF4.Left = pntInicio.Left;
                    pcbF4.Top = pntInicio.Top;
                }
                if ((pcbF4.Bounds.IntersectsWith(pcbPacMan.Bounds)) && (podeComer == false))
                {
                    vidaPac = vidaPac - 1;
                    derrota(vidaPac);
                }
                if (pcbF4.Left < 0)
                {
                    pcbF4.Left = 626;
                    pcbF4Esq = true;
                }
                else if (pcbF4.Left > 626)
                {
                    pcbF4.Left = 0;
                    pcbF4Dir = true;
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = e.KeyChar;
            // MessageBox.Show(c.ToString());
            if (c == 65 || c == 97)
            {
                pcbPacMan.Left -= 1;
            }
            else if (c == 115 || c == 83){
                pcbPacMan.Left += 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if(e.KeyCode == Keys.Left)
            {
                dir = false;
                esq = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                dir = true;
                esq = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                esq = false;
                dir = false;
                baixo = false;
                cima = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                baixo = true;
                cima = false;
                esq = false;
                dir = false;
            }
            if (e.KeyCode != null && comecar ==false)
            {
                comecar = true;
                tmFInicio.Start();
            }

        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parede2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel62_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parede1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmInicio_Tick(object sender, EventArgs e)
        {
            
            Opacity += 0.1;
            if(Opacity == 1)
            {
                tmInicio.Enabled = false;
            }
        }

        private void tmFInicio_Tick(object sender, EventArgs e)
        {
            if (comecar == true)
            {
                pcbV3.Visible = false;
                tempoT += 1;
            }
            if (tempoT == 1)
            {
                F1seguir = true;
            }
            else if (tempoT == 2)
            {
                F2seguir = true;
            }
            else if (tempoT == 3)
            {
                F3seguir = true;
            }
            else if (tempoT==4)
            {
                F4seguir = true;
                vidaPac -= 1;
                tempoT= 0;
                tmFInicio.Stop();
            }
        }
        public void pegarFrutas()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is PictureBox &&
                    ctl.Name != "pcbPacMan" &&
                    pcbPacMan.Bounds.IntersectsWith(ctl.Bounds) && ctl.Name != "pcbF1" && ctl.Name != "pcbF2" && ctl.Name != "pcbF3" && ctl.Name != "pcbF4" && ctl.Name !="pntInicio" && ctl.Visible == true)
                {
                    contFrutas += 1;
                    ctl.Visible = false;
                    pontos += 10;
                    label2.Text = pontos.ToString();

                    if (ctl.Name== "pctFrutE1"|| ctl.Name == "pctFrutE2" || ctl.Name == "pctFrutE3" || ctl.Name == "pctFrutE4"|| ctl.Name == "pctFrutE5"|| ctl.Name == "pctFrutE6")
                    {
                        podeComer = true;
                        tmCmF.Start();
                    }

                    if (pontos == 1190)
                    {
                        vitoria();
                    }
                }
            }
        }

        private void tmCmF_Tick(object sender, EventArgs e)
        {
            tempoComer += 1;
            if (tempoComer == 10)
            {
                tempoComer = 0;
                podeComer = false;
                tmCmF.Stop();
            }
        }

        public void vitoria()
        {
            MessageBox.Show("Vitoria");
        }
        public void volta()
        {
            tmFInicio.Start();
            pcbF1.Left = pntInicio.Left;
            pcbF2.Left = pntInicio.Left;
            pcbF3.Left = pntInicio.Left;
            pcbF4.Left = pntInicio.Left;
            pcbF1.Top = pntInicio.Top;
            pcbF2.Top = pntInicio.Top;
            pcbF3.Top = pntInicio.Top;
            pcbF4.Top = pntInicio.Top;
            F1seguir = false;
            F2seguir = false;
            F3seguir = false;
            F4seguir = false;
        }
        public void derrota(int vida)
        {
            if (vida == 1)
            {
                pcbPacMan.Left = 297;
                pcbPacMan.Top = 422;
                pcbV2.Visible = false;
                volta();
            }
            else if (vida == -1)
            {
                pcbPacMan.Left = 297;
                pcbPacMan.Top = 422;
                pcbV1.Visible = false;
                volta();
            }
            else
            {
                //Fim
                MessageBox.Show("Fim");
            }
        }
        

        public void colisao()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Panel && ctl.Name!="pnlFim" && pcbPacMan.Bounds.IntersectsWith(ctl.Bounds) && cima == true)
                {
                    pcbPacMan.Top += 3;
                    cima = false;
                }
                if (ctl is Panel && ctl.Name != "pnlFim" && pcbPacMan.Bounds.IntersectsWith(ctl.Bounds) && baixo == true)
                {
                    pcbPacMan.Top -= 3;
                    baixo = false;
                }
                if (ctl is Panel && ctl.Name != "pnlFim" && pcbPacMan.Bounds.IntersectsWith(ctl.Bounds) && dir == true)
                {
                    pcbPacMan.Left -= 3;
                    dir = false;
                }
                if (ctl is Panel && ctl.Name != "pnlFim" && pcbPacMan.Bounds.IntersectsWith(ctl.Bounds) && esq == true)
                {
                    pcbPacMan.Left += 3;
                    esq = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pegarFrutas();
           // colisao();
            tempo += 1;
            if (dir == true) {
                pcbPacMan.Left += 3;
                colisao();
                if (tempo == 1)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac3;
                }
                else if (tempo == 2)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2;
                }
                else if (tempo==3) { 
                    pcbPacMan.Image = Aula11.Properties.Resources.pac1;
                }
                else if (tempo == 4)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac3;
                }
                else if (tempo == 5)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2;
                }
                else
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac1;
                    tempo = 0;
                }
            }
            else if (esq==true)
            {
                pcbPacMan.Left -= 3;
                colisao();
                if (tempo == 1)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac3;
                }
                else if (tempo == 2)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2Esquerda;
                }
                else
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac1Esquerda;
                    tempo = 0;
                }
            }
            else if (cima == true)
            {
                pcbPacMan.Top -= 3;
                colisao();
                if (tempo == 1)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac3;
                }
                else if (tempo == 2)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2Cima;
                }
                else
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2Cima;
                    tempo = 0;
                }
            }
            else if (baixo == true)
            {
                pcbPacMan.Top += 3;
                colisao();
                if (tempo == 1)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac3;
                }
                else if (tempo == 2)
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac2Baixo;
                }
                else
                {
                    pcbPacMan.Image = Aula11.Properties.Resources.pac1Baixo;
                    tempo = 0;
                }
            }
            if (pcbPacMan.Left < 0)
            {
                pcbPacMan.Left = 626;
                esq = true;
            }
            else if (pcbPacMan.Left > 626)
            {
                pcbPacMan.Left = 0;
                dir = true;
            }


        }
    }
}
