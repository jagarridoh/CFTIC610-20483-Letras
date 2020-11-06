using System;
using System.Collections.Generic;
using System.Reflection;
//using System.Linq;

namespace LetrasPOO
{
    public abstract class GestionLetras {
        public string frase { get; private set;} = "";
        //private SortedList<char, Letra> dicLet = new SortedList<char,Letra>();
        //private diccLetras = new Dictionary<char,Letra>();
        public Dictionary<char,Letra> diccLetras;
        public abstract string LeerFraseDeTeclado();
        public abstract void ImprimirFrase(string frase);
        public abstract void InicializarDiccionarioDeClases();
    }

    public class GestionLetrasImpl : GestionLetras {
        public override string LeerFraseDeTeclado() {
            //TODO 
            return "";
        }

        public override void ImprimirFrase(string frase)
        {
            // TODO
            throw new NotImplementedException();
        }

        public override void InicializarDiccionarioDeClases() {
            // TODO
            Console.WriteLine("Ini de InicializarDiccionarioDeClases");
            var tipoLetraA = Type.GetType("LetrasPOO.Letra" + "A");
            var constructor = tipoLetraA.GetConstructor(new Type[0]);
            var miLetraA = (Letra) constructor.Invoke(new object[0]);
           miLetraA.test();
            Console.WriteLine("Fin de InicializarDiccionarioDeClases");
            //throw new NotImplementedException();
        }
    }


}