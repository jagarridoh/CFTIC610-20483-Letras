using System;
using System.Collections.Generic;
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
        protected abstract void InicializarDiccionarioDeClases();
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

        protected override void InicializarDiccionarioDeClases() {
            // TODO
            throw new NotImplementedException();
        }
    }


}