using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasPOO
{
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

}