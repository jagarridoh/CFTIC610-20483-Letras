using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionLetras gl = new GestionLetrasImpl();
            string frase = gl.LeerFraseDeTeclado();
            gl.ImprimirFrase(frase);

 /*     new letraA().test();
        new letraG().test();
*/

            letraL L = new letraL();
            L.test();
            L.juntarletras (new letraI());
            L.juntarletras (new letraM());
            L.juntarletras (new letraN());
            L.juntarletras (new letraD());
            L.juntarletras (new letraG());
            L.juntarletras (new letraA());
            L.juntarletras (new letraP());
            L.juntarletras (new letraQ());
            L.test();
        }
     }

     public class Palabra : Letra
     {
        string mipalabra {get;set;}
        public Palabra()
        {
                for (int i=0; i < limite ; i++)
                Matriz[i] = "";
        }

     

        public override void  test()
        {
            Console.WriteLine ("una palabra no puede testearse");
        }
       

     }
  


  






    public enum letraspermitidas {A , B, C , D , E , F, G , H , I ,J , K , L, M, N, P, Q };

    public abstract class Letra 
    {
        protected const int limite = 7;
        protected string[] matriz7X7 = new string[limite] ;
        public string Nombre {get;set;}
        public string[]  Matriz {
            get { return matriz7X7 ;}
            set { matriz7X7 = value;}
         }
        public  virtual void pintar()
        {
            for (int i=0; i < limite; i++ )
            { Console.WriteLine ( Matriz [i]);}
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
            for (int i=0; i < limite ; i++)
            { 
                    Matriz[i] +=  letra.Matriz[i]  + " ";
    
            }
        }

    }

 public sealed class letraA : Letra
    {
        public letraA()
        {
            base.Nombre ="A";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "*     *";
            base.Matriz [2] = "*     *";
            base.Matriz [3] = "*******";
            base.Matriz [4] = "*     *";
            base.Matriz [5] = "*     *";
            base.Matriz [6] = "*     *";
        }
     }
 public sealed class letraB : Letra
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
     }
 public sealed class letraC : Letra
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

    }
 public sealed class letraD : Letra
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
     }
 public sealed class letraE : Letra
    {
        public letraE()
        {
            base.Nombre ="E";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "*      ";
            base.Matriz [2] = "*      ";
            base.Matriz [3] = "*******";
            base.Matriz [4] = "*      ";
            base.Matriz [5] = "*      ";
            base.Matriz [6] = "*******";
        }
     }
 public sealed class letraF : Letra
    {
        public letraF()
        {
            base.Nombre ="F";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "*      ";
            base.Matriz [2] = "*      ";
            base.Matriz [3] = "****   ";
            base.Matriz [4] = "*      ";
            base.Matriz [5] = "*      ";
            base.Matriz [6] = "*      ";
        }

    }
 public sealed class letraG : Letra
    {
        public letraG()
        {
            base.Nombre ="G";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "*      ";
            base.Matriz [2] = "*      ";
            base.Matriz [3] = "*  ****";
            base.Matriz [4] = "*     *";
            base.Matriz [5] = "*     *";
            base.Matriz [6] = "*******";
        }
     }
 public sealed class letraH : Letra
    {
        public letraH()
        {
            base.Nombre ="H";
            base.Matriz [0] = "*     *";
            base.Matriz [1] = "*     *";
            base.Matriz [2] = "*     *";
            base.Matriz [3] = "*******";
            base.Matriz [4] = "*     *";
            base.Matriz [5] = "*     *";
            base.Matriz [6] = "*     *";
        }
     }
 public sealed class letraI : Letra
    {
        public letraI()
        {
            base.Nombre ="I";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "   *   ";
            base.Matriz [2] = "   *   ";
            base.Matriz [3] = "   *   ";
            base.Matriz [4] = "   *   ";
            base.Matriz [5] = "   *   ";
            base.Matriz [6] = "*******";
        }

    }
 public sealed class letraJ : Letra
    {
        public letraJ()
        {
            base.Nombre ="J";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "    * ";
            base.Matriz [2] = "    * ";
            base.Matriz [3] = "    * ";
            base.Matriz [4] = "*   * ";
            base.Matriz [5] = "*   * ";
            base.Matriz [6] = "***** ";
        }
     }
 public sealed class letraK : Letra
    {
        public letraK()
        {
            base.Nombre ="K";
            base.Matriz [0] = "*    **";
            base.Matriz [1] = "*  **  ";
            base.Matriz [2] = "* **   ";
            base.Matriz [3] = "**     ";
            base.Matriz [4] = "* **   ";
            base.Matriz [5] = "*  **  ";
            base.Matriz [6] = "*    **";
        }
     }
 public sealed class letraL : Letra
    {
        public letraL()
        {
            base.Nombre ="L";
            base.Matriz [0] = "*      ";
            base.Matriz [1] = "*      ";
            base.Matriz [2] = "*      ";
            base.Matriz [3] = "*      ";
            base.Matriz [4] = "*      ";
            base.Matriz [5] = "*      ";
            base.Matriz [6] = "*******";
        }

    }







}
