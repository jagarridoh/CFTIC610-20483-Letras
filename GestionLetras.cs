using System;
using System.Collections.Generic;
using System.Reflection;

namespace LetrasPOO
{
    public abstract class GestionLetras {
        public string frase { get; protected set;} = "";
        public Dictionary<LetrasPermitidas, Letra> diccLetras;
        public abstract void LeerFraseDeTeclado();
        public abstract void ImprimirFrase();
        public abstract void InicializarDiccionarioDeClases();
    }

    public class GestionLetrasImpl : GestionLetras {

        public GestionLetrasImpl()
        {
            diccLetras = new Dictionary<LetrasPermitidas, Letra>();
        }

        public override void LeerFraseDeTeclado() {
            frase = System.Console.ReadLine();
        }

        public override void ImprimirFrase()
        {
            LetrasPermitidas miLetraPermitida;
            Letra l;
            char c;
            for (int fila=0; fila < Letra.limite; fila++)
            {
                for(int columna = 0; columna < frase.Length; columna++)
                {
                    c = frase.ToCharArray()[columna];
                    miLetraPermitida = (LetrasPermitidas) Enum.Parse(typeof(LetrasPermitidas), "" + c, true);
                    l = diccLetras.GetValueOrDefault(miLetraPermitida);
                    Console.Write("{0} ", l.Matriz[fila]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine(frase);
        }

        public override void InicializarDiccionarioDeClases() {
            Type claseLetra;
            ConstructorInfo constructor;
            Letra objetoLetra;
            foreach (LetrasPermitidas c in Enum.GetValues(typeof(LetrasPermitidas)))
            {
                claseLetra = Type.GetType("LetrasPOO.Letra" + c);
                constructor = claseLetra.GetConstructor(new Type[0]);
                objetoLetra = (Letra) constructor.Invoke(new object[0]);
                diccLetras.Add(c, objetoLetra);
                Console.Write("{0} añadida. ", c);
            }
            Console.WriteLine("");
            Console.WriteLine("Las letras disponibles son:");
            foreach (LetrasPermitidas c in Enum.GetValues(typeof(LetrasPermitidas)))
            {
                diccLetras.GetValueOrDefault(c).test();
            }
        }
    }


}