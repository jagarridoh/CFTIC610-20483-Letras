using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* GestionLetras gl = new GestionLetrasImpl();
             string frase = gl.LeerFraseDeTeclado();
             gl.ImprimirFrase(frase);
 */
            /*     new letraA().test();
                   new letraG().test();
           */

            LetraL L = new LetraL();
            L.test();
            L.juntarletras(new LetraI());
            L.juntarletras(new LetraM());
            L.juntarletras(new LetraN());
            L.juntarletras(new LetraD());
            L.juntarletras(new LetraG());
            L.juntarletras(new LetraA());
            L.juntarletras(new LetraP());
            L.juntarletras(new LetraQ());
            L.test();
        }
    }

    public class Palabra : Letra
    {
        string mipalabra { get; set; }
        public Palabra()
        {
            for (int i = 0; i < limite; i++)
                Matriz[i] = "";
        }



        public override void test()
        {
            Console.WriteLine("una palabra no puede testearse");
        }


    }










    public enum LetrasPermitidas { A, B, C, D, E, F, G, H, I, J, K, L, M, N, Ñ, O, P, Q, S, V, Z };

    public abstract class Letra
    {
        protected const int limite = 7;
        protected string[] matriz7X7 = new string[limite];
        public string Nombre { get; set; }
        public string[] Matriz
        {
            get { return matriz7X7; }
            set { matriz7X7 = value; }
        }
        public virtual void pintar()
        {
            for (int i = 0; i < limite; i++)
            { Console.WriteLine(Matriz[i]); }
        }
        public virtual void test()
        {
            Console.WriteLine(this.Nombre);
            Console.WriteLine();
            pintar();
        }

        public void juntarletras(Letra letra)
        {
            this.Nombre += letra.Nombre;
            for (int i = 0; i < limite; i++)
            {
                Matriz[i] += letra.Matriz[i] + " ";

            }
        }

    }

    public sealed class LetraA : Letra
    {
        public LetraA()
        {
            base.Nombre = "A";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "*     *";
            base.Matriz[2] = "*     *";
            base.Matriz[3] = "*******";
            base.Matriz[4] = "*     *";
            base.Matriz[5] = "*     *";
            base.Matriz[6] = "*     *";
        }
    }
    /*public sealed class letraB : Letra
       {
           public letraB()
           {
               base.Nombre ="B";
               base.Matriz [0] = "*******";
               base.Matriz [1] = "*     *";
               base.Matriz [2] = "*     *";
               base.Matriz [3] = "*******";
               base.Matriz [4] = "*     *";
               base.Matriz [5] = "*     *";
               base.Matriz [6] = "*******";
           }
        }*/
    /*public sealed class letraC : Letra
       {
           public letraC()
           {
               base.Nombre ="C";
               base.Matriz [0] = "*******";
               base.Matriz [1] = "*      ";
               base.Matriz [2] = "*      ";
               base.Matriz [3] = "*      ";
               base.Matriz [4] = "*      ";
               base.Matriz [5] = "*      ";
               base.Matriz [6] = "*******";
           }

       }*/
    /*public sealed class letraD : Letra
       {
           public letraD()
           {
               base.Nombre ="D";
               base.Matriz [0] = "*******";
               base.Matriz [1] = "*     *";
               base.Matriz [2] = "*     *";
               base.Matriz [3] = "*     *";
               base.Matriz [4] = "*     *";
               base.Matriz [5] = "*     *";
               base.Matriz [6] = "*******";
           }
        }*/
    public sealed class LetraE : Letra
    {
        public LetraE()
        {
            base.Nombre = "E";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "*      ";
            base.Matriz[2] = "*      ";
            base.Matriz[3] = "*******";
            base.Matriz[4] = "*      ";
            base.Matriz[5] = "*      ";
            base.Matriz[6] = "*******";
        }
    }
    public sealed class LetraF : Letra
    {
        public LetraF()
        {
            base.Nombre = "F";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "*      ";
            base.Matriz[2] = "*      ";
            base.Matriz[3] = "****   ";
            base.Matriz[4] = "*      ";
            base.Matriz[5] = "*      ";
            base.Matriz[6] = "*      ";
        }

    }
    public sealed class LetraG : Letra
    {
        public LetraG()
        {
            base.Nombre = "G";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "*      ";
            base.Matriz[2] = "*      ";
            base.Matriz[3] = "*  ****";
            base.Matriz[4] = "*     *";
            base.Matriz[5] = "*     *";
            base.Matriz[6] = "*******";
        }
    }
    public sealed class LetraH : Letra
    {
        public LetraH()
        {
            base.Nombre = "H";
            base.Matriz[0] = "*     *";
            base.Matriz[1] = "*     *";
            base.Matriz[2] = "*     *";
            base.Matriz[3] = "*******";
            base.Matriz[4] = "*     *";
            base.Matriz[5] = "*     *";
            base.Matriz[6] = "*     *";
        }
    }
    public sealed class LetraI : Letra
    {
        public LetraI()
        {
            base.Nombre = "I";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "   *   ";
            base.Matriz[2] = "   *   ";
            base.Matriz[3] = "   *   ";
            base.Matriz[4] = "   *   ";
            base.Matriz[5] = "   *   ";
            base.Matriz[6] = "*******";
        }

    }
    public sealed class LetraJ : Letra
    {
        public LetraJ()
        {
            base.Nombre = "J";
            base.Matriz[0] = "*******";
            base.Matriz[1] = "    * ";
            base.Matriz[2] = "    * ";
            base.Matriz[3] = "    * ";
            base.Matriz[4] = "*   * ";
            base.Matriz[5] = "*   * ";
            base.Matriz[6] = "***** ";
        }
    }
    public sealed class LetraK : Letra
    {
        public LetraK()
        {
            base.Nombre = "K";
            base.Matriz[0] = "*    **";
            base.Matriz[1] = "*  **  ";
            base.Matriz[2] = "* **   ";
            base.Matriz[3] = "**     ";
            base.Matriz[4] = "* **   ";
            base.Matriz[5] = "*  **  ";
            base.Matriz[6] = "*    **";
        }
    }
    public sealed class LetraL : Letra
    {
        public LetraL()
        {
            base.Nombre = "L";
            base.Matriz[0] = "*      ";
            base.Matriz[1] = "*      ";
            base.Matriz[2] = "*      ";
            base.Matriz[3] = "*      ";
            base.Matriz[4] = "*      ";
            base.Matriz[5] = "*      ";
            base.Matriz[6] = "*******";
        }

    }







}
