using System;
//using System.Collections.Generic;
//using System.Linq;

namespace LetrasPOO
{
    public abstract class GestionLetras {
        public string frase { get; private set;} = "";
        //¡¡¡private Dictionary<char, Letra> dicLet = new Dictionary<char,Letra>();
        private diccLetras = new Dictionary<char,Letra>();
        public abstract string LeerFraseDeTeclado();
        public abstract void ImprimirFrase(string frase);
        private abstract void InicializarDiccionarioDeClases();
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

        private abstract void InicializarDiccionarioDeClases() {
            // TODO
            throw new NotImplementedException();
        }
    }


}