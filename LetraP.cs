namespace LetrasPOO
{
    public sealed class LetraP : Letra
    {
        public LetraP()
        {
            base.Nombre = "P";
            base.Matriz[0] = "****** ";
            base.Matriz[1] = "*     *";
            base.Matriz[2] = "*     *";
            base.Matriz[3] = "****** ";
            base.Matriz[4] = "*      ";
            base.Matriz[5] = "*      ";
            base.Matriz[6] = "*      ";
        }
    }
}