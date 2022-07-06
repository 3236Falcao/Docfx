using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Docfx
{
    /// <summary>
    /// Classe de Calculos
    /// Contém todos os métodos para executar funções matemáticas básicas.
    /// </summary>
    public class Calculos
    {
        /// <summary> 
        /// Adiciona dois inteiros e retorna o resultado.
        /// </summary>
        /// <returns>
        /// A soma de dois inteiros
        /// </returns>
        public void Inicio()
        {
            /// <summary> 
            /// Inicio do projeto
            /// </summary>

            List<string> listaResultados = new List<string>();
            var MyClass = new Calculos();
            Console.WriteLine("Bem vindo Dev!");
            //MyClass.AdicionaNumeroArray();
            //MyClass.SomaValoresArray();
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("__________________________________________");
            Console.WriteLine("Olá " + nome + ", Vamos jogar?");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            int decisaoDeIniciar = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");

            if (decisaoDeIniciar == 1)
            {
                Console.WriteLine("Que legal!");
                Thread.Sleep(500);
                Console.Clear();
                MyClass.ChamarMetodos(listaResultados);
            }
            else
            {
                Console.WriteLine("Que pena , então vamos deixar para a próxima.");
                Environment.Exit(decisaoDeIniciar);
            }

        }
        public int SomarNumeros(int numero1, int numero2)
        {
            /// <summary> 
            /// Metodo de somar
            /// </summary>
            var resultadoSoma = (numero1 + numero2);
            return resultadoSoma;
        }

        public int SubtrairNumeros(int numero1, int numero2)
        {
            /// <summary> 
            /// Metodo de subtrair
            /// </summary>
            var resultadoSubtracao = (numero1 - numero2);
            return resultadoSubtracao;
        }

        public int MultiplicarNumeros(int numero1, int numero2)
        {
            /// <summary> 
            /// Metodo de multiplicar
            /// </summary>
            var resultadoMultiplicao = (numero1 * numero2);
            return resultadoMultiplicao;
        }

        public int DividirNumeros(int numero1, int numero2)
        {
            /// <summary> 
            /// Metodo de dividir
            /// </summary>
            var resultadoDivisao = (numero1 / numero2);
            return resultadoDivisao;
        }

        public void ChamarMetodos(List<string> listaResultados)
        {
            /// <summary> 
            /// Procedimento que chama os métodos
            /// </summary>

            Console.Clear();
            string mensagem = "";
            int valor = 0;
            int recebeOpcao = 0;
            var MyClass = new Calculos();

            //Adicionado contador
            Console.WriteLine("conta " + (listaResultados.Count + 1));
            Console.WriteLine("Digite dois numeros");
            //como validar se o valor chegar vazio???

            //int valor1 = (Console.ReadLine().Trim() == "" ? "Digite um valor válido." : int.Parse(Console.ReadLine());
            //string valor1 = (Console.ReadLine().Trim() == "" ? "Digite um valor válido." : valor1.int.Parse(Console.ReadLine()));

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("__________________________________________");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            recebeOpcao = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________________________");

            do
            {
                //Valida recebeOpcao

                if (recebeOpcao == 1)
                {
                    valor = MyClass.SomarNumeros(valor1, valor2);
                    mensagem = "A soma de " + valor1 + " + " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 2)
                {
                    valor = MyClass.SubtrairNumeros(valor1, valor2);
                    mensagem = "A subtração de " + valor1 + " - " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 3)
                {
                    valor = MyClass.MultiplicarNumeros(valor1, valor2);
                    mensagem = "A multiplicação de " + valor1 + " x " + valor2 + " é igual a " + (valor);
                }
                else if (recebeOpcao == 4)
                {
                    valor = MyClass.DividirNumeros(valor1, valor2);
                    mensagem = "A divisão de " + valor1 + " / " + valor2 + " é igual a " + (valor);
                }
                else
                {
                    Console.WriteLine(recebeOpcao + " é uma opção inválida!");
                }

                //Valida mensagem
                if (mensagem != "")
                {
                    Console.WriteLine(mensagem);
                    listaResultados.Add(mensagem);
                }

                Console.WriteLine("__________________________________________");

                Console.WriteLine("Vamos continuar brincando?");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                var decisaoDeContinuar = int.Parse(Console.ReadLine());

                if (decisaoDeContinuar == 1)
                {
                    Console.WriteLine("Que legal!");
                    Console.WriteLine("__________________________________________");

                    //Sleep: bloqueia o thread principal por 1segundo
                    Thread.Sleep(500);
                    Console.Clear();
                    ChamarMetodos(listaResultados);
                }
                else if (decisaoDeContinuar == 2)
                {
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("Que pena , então vamos deixar para a próxima.");
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("A quantidade de contas realizadas foi: " + listaResultados.Count);
                    Console.WriteLine("");
                    Console.WriteLine("Lista de contas: ");

                    for (int i = 0; i < listaResultados.Count; i++)
                    {
                        //Console.WriteLine(i + " - " + listaResultados[i].NomeConta + " - " + listaResultados[i].TempoIdeal + " - " + listaResultados[i].TempoReal);                
                        Console.WriteLine("Conta " + (i + 1) + " - " + listaResultados[i]);
                    }
                    //Environment: Encerra o processo "decisaoDeContinuar" e retorna um código de saída para o sistema operacional.
                    Environment.Exit(decisaoDeContinuar);
                }
                else
                {
                    Console.WriteLine("Você deve digitar 1 para sim e 2 para não. Tente novamente");
                    //Sleep: bloqueia o thread principal por 1segundo
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                ChamarMetodos(listaResultados);
                AdicionaNumeroList(listaResultados);
            } while (recebeOpcao >= 1 || recebeOpcao <= 4);
        }

        public void AdicionaNumeroList(List<string> listaResultados)
        {
            /// <summary> 
            /// Metodo que adiciona numero na lista de contas realizadas
            /// </summary>

            //Declaração de um array inteiro com 4 posições       
            int[] a = { 1, 2, 3, 4 };

            //Declaração de uma variavel b que recebe valores que serão inseridos em a
            int b = int.Parse(Console.ReadLine());

            //Adicionando valores de b em a com for
            for (int i = 0; i <= a.Length; i++)
            {
                //Mostra o valor em cada posição
                Console.WriteLine(i);
                //Console.WriteLine(a.Length);             
            }
        }

        //public bool VerificaTamanhoList()
        //{
            /// <summary> 
            /// Metodo que verifica o tamanho da lista e retorna um valor boleano
            /// </summary>

            //Comparaçãoa de arrays
            //while ()
            //{
            //    Console.WriteLine(A array não foi alterado);
            //}


            //Criar novo array para receber valores que são inseridos pelo usuario

        //}

        public void SomaValoresArray()
        {
            /// <summary> 
            /// Metodo de somar todos os valores adicionados
            /// </summary>
            var MyClass = new Calculos();
            //array de 10 valores
            //int[] valores = new int[3];
            int[] valores = { 1, 2, 3 };

            //declaração de variavel que vai receber a soma dos valores que serão inseridos
            decimal soma = 0;

            //declaração de variavel do tipo decimal
            decimal media = 0;

            //Estrutura de repetição que utilizamos quando sabemos a quantidade de repetições que um bloco de código deve ser executado
            //i é o indice do array. Enquanto i for menor que 3 repete o for
            for (int i = 0; i < 4; i++)
            {
                if (i <= 3)
                {
                    //Pede que o usuario digite um valor
                    Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));

                    //Guarda o valor inserido na variavel valores em uma determinada posição            
                    valores[i] = int.Parse(Console.ReadLine());
                }
                else
                {
                    //Chama a função que verifica o tamanho do array
                    //MyClass.VerificaTamanhoList();

                }

                //soma os valores inseridos em valores
                //soma += valores[i];
            }
            //media = soma / 10;

            Console.WriteLine("Soma dos valores inseridos é igual a  " + soma);


            for (int i = 0; i < 4; i++)
            {
                //if (valores[i] < media)
                //Console.WriteLine(String.Format("O elemento de índice {0}, cujo valor é {1}, está abaixo da média.", i, valores[i]));
            }

        }
    }
}



