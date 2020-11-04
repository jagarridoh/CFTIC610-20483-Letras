using System;
//using System.Collections.Generic;
//using System.Linq;

namespace LetrasPOO
{
    public abstract class GestionLetras {
        public abstract string LeerFraseDeTeclado();
        public abstract void ImprimirFrase(string frase);
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
    }


}