using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasPOO
{
    public sealed class LetraG : Letra
    {
        public LetraG()
        {
            base.Nombre ="G";
            base.Matriz [0] = "*******";
            base.Matriz [1] = "*      ";
            base.Matriz [2] = "*      ";
            base.Matriz [3] = "*"      ;
            base.Matriz [4] = "*   ***";
            base.Matriz [5] = "*     *";
            base.Matriz [6] = "*******";
        }

    }

}
