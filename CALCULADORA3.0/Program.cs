using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //sair
            string sair = "";
            while (sair != "exit") {
                Console.Clear();
                //Declaração de variaveis
                string valores;
                double resultado = 0;
                //adicao
                int e = 0;
                //subtração
                int s1 = 0;
                //multiplicação
                int m1 = 0;
                //divisão
                int d1 = 0;

                //multi
                int multi = 0;
                int Pmulti = 0;
                //divi
                int divi = 0;
                int divprim = 0;


                //Posições (Variavel que guarda a posição de cada número)
                int posicoes = 1;

                //Entrada de Dados

                Console.WriteLine("Digite");
            valores = Console.ReadLine();
                try {
            valores = valores.Trim();

            //Criando vetores que vão armazenar que números vão ser somados,dividiso e etc...
            int[] adicao=new int[valores.Length];
            int[] sub = new int[valores.Length];
            int[] mul = new int[valores.Length];
            int[] div = new int[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                //Comparando cada caracter da variavel valores
                //e vendo se existe um dos operadores
                if (valores.Substring(i, 1) == "+")
                {
                    posicoes += 1;
                    adicao[e] = posicoes;
                    e += 1;

                }
               if (valores.Substring(i, 1) == "-")
                {
                    posicoes += 1;
                    sub[s1] = posicoes;
                    s1 += 1;

                }
                if (valores.Substring(i, 1) == "x")
                {
                    posicoes += 1;
                    mul[m1] = posicoes;
                    m1 += 1;

                }
                if (valores.Substring(i, 1) == "/")
                {
                    posicoes += 1;
                    div[d1] = posicoes;
                    d1 += 1;

                }
            }

            //Armazenando em um vetor o Split da variavel valores
            //tirando assim os operadores e deixando apenas os numeros
            string[] split_numeros = valores.Split('+', '-','x','/');

            //Vetor que irá armazenar a conversao de string para float do vetor
            //que esta guardando os valores
            double[] conv_valores = new double[split_numeros.Length];

            for (int i = 0; i < conv_valores.Length; i++)
            {
                conv_valores[i] = Convert.ToDouble(split_numeros[i]);
            }
            resultado = conv_valores[0];

            for (int i = 0; i < conv_valores.Length; i++)
            {
                if (div[i] != 0)
                {
                    div[i] -= 1;
                    //Console.WriteLine("dividir posicao:" + div[i] + " com Resultado da soma");
                    //Console.WriteLine("Resultado:" + resultado);
                    if (div[i] > 1)
                    {
                        divi = div[i];
                        for (int x = 0; x < conv_valores.Length; x++)
                        {
                            if (sub[x] == divi)
                            {
                                sub[x] -= 1;
                                    Console.Write(conv_valores[sub[x]] + " / " + conv_valores[div[i]]+" = ");
                                    conv_valores[sub[x]] = conv_valores[sub[x]] /conv_valores[div[i]];
                                    Console.WriteLine(conv_valores[sub[x]]);
                                    conv_valores[div[i]] = conv_valores[adicao[x]] / conv_valores[div[i]];
                                    //Console.WriteLine(conv_valores[sub[x]]);
                                    sub[x] += 1;
                            }
                            else if (adicao[x] == divi)
                            {
                                adicao[x] -= 1;
                                    Console.Write(conv_valores[adicao[x]] + " / " + conv_valores[div[i]] + " = ");
                                    conv_valores[adicao[x]] = conv_valores[adicao[x]] / conv_valores[div[i]];
                                    conv_valores[div[i]] = conv_valores[adicao[x]] / conv_valores[div[i]];
                                    Console.WriteLine(conv_valores[adicao[x]]);
                                    //Console.WriteLine("Dentro do if valor de covValores " + conv_valores[adicao[x]] + " Valor de MUL " + conv_valores[div[i]]);
                                    adicao[x] += 1;
                            }
                            //Console.WriteLine("Fora do if " + sub[x]);
                        }
                    }
                    else
                    {
                            Console.Write(resultado + " / " + conv_valores[div[i]] + " = ");
                            resultado = resultado / conv_valores[div[i]];
                            Console.WriteLine(resultado);
                            divprim += 1;

                        }
                }
            }

            for (int i = 0; i < conv_valores.Length; i++)
            {
                if (mul[i] != 0)
                {
                    mul[i] -= 1;
                    if (mul[i] > 1)
                    {
                        multi = mul[i];
                        //Console.WriteLine("multiplicar posicao:" + mul[i] + " com Resultado da soma");
                        for(int x = 0; x < conv_valores.Length; x++)
                        {
                                div[x] += 1;
                                if (sub[x] == multi)
                                {
                                    sub[x] -= 1;
                                    conv_valores[sub[x]] = conv_valores[sub[x]] * conv_valores[mul[i]];
                                    //Console.WriteLine("Dentro do if valor de covValores "+conv_valores[sub[x]]+" Valor de MUL "+conv_valores[mul[i]]);
                                    sub[x] += 1;
                                }
                                else if (adicao[x] == multi)
                                {
                                    adicao[x] -= 1;
                                    conv_valores[adicao[x]] = conv_valores[adicao[x]] * conv_valores[mul[i]];
                                    //Console.WriteLine("Dentro do if valor de covValores " + conv_valores[adicao[x]] + " Valor de MUL " + conv_valores[mul[i]]);
                                    adicao[x] += 1;
                                }
                                else if (div[x] == multi)
                                {
                                    if (divprim<1) { 

                                     div[x] -= 2;
                                    Console.Write(conv_valores[div[x]] + " x " + conv_valores[mul[i]] + " = ");
                                    conv_valores[div[x]] = conv_valores[div[x]] * conv_valores[mul[i]];
                                    Console.WriteLine(conv_valores[div[x]]);
                                    //resultado = resultado + conv_valores[div[x]];
                                    div[x] += 2;
                                    }
                                    else {
                                        Console.Write(resultado + " x " + conv_valores[mul[i]] + " = ");
                                        resultado = resultado * conv_valores[mul[i]];
                                        Console.WriteLine(resultado);
                                    }
                                }
                                //Console.WriteLine("Fora do if "+ sub[x]);
                        }
                    }
                    else { 
                    resultado = resultado * conv_valores[mul[i]];
                    }
                    //Console.WriteLine("Resultado:" + resultado);
                }
            }

            for (int i = 0; i < conv_valores.Length; i++)
            {
               if (adicao[i] != 0) {
                    adicao[i] -= 1;
                    Console.Write(resultado+" + "+ conv_valores[adicao[i]]+" = ");
                    resultado += conv_valores[adicao[i]];
                    Console.WriteLine(resultado);
                    //Console.WriteLine("Resultado:" + resultado);
                }
            }
            for (int i = 0; i < conv_valores.Length; i++)
            {
                if (sub[i] != 0)
                {
                    sub[i] -= 1;
                    //Console.WriteLine("subtrair posicao:" + sub[i] + " com Resultado da soma");
                    //Console.WriteLine(conv_valores[sub[i]]);
                        Console.Write(resultado + " - " + conv_valores[sub[i]]+" = ");
                        resultado -= conv_valores[sub[i]];
                        Console.WriteLine(resultado);
                        //Console.WriteLine("Resultado:" + resultado);
                    }
            }
            //Console.WriteLine(valores);
         
            Console.WriteLine("Resultado:"+resultado);
            Console.WriteLine("Digite exit para sair");
            sair = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Por favor Digite Novamente");
                }
                Console.ReadKey();
        }
            }
        }
    }
