### CFTIC610-20483-Letras

Trabajo de toda la clase CFTIC610 creando aplicación de Consola de tratamiento de letras.


###### Definición de la clase abstrata letra

Tras ver los programas he pensado que la forma más sencilla de generar la matriz de simbolos es la que empleo Miguel Angel, siendo un Array [7] de string

````
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

``````

Defino los metodos virtuales por si necesito sobreescribirlos



Ejemplo de una clase letraF`


podemos ejecutar el método heredado test para ver como lo pinta 
ejemplo  new letraA().test();

`````
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
``````

ejemplo 

    letraL L = new letraL();
    L.test();
    L.juntarletras (new letraI());
    L.juntarletras (new letraG());
    L.juntarletras (new letraA());
    L.test();
    
``````

*       ******* ******* *******
*          *    *       *     *
*          *    *       *     *
*          *    *  **** *******
*          *    *     * *     *
*          *    *     * *     *
******* ******* ******* *     *

``````







