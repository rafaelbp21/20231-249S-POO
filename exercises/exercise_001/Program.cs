using Sistema_Barbaro.Sistema_Barbaro;
using System;

namespace Sistema_Barbaro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Classe barbaro1 = new Classe
            {
                Nome = "Cleiton Barbaro",              
            };

            barbaro1.Status();
          

            Classe barbaro2 = new Classe
            {
                Nome = "Jeferson Barbaro",

            };

            barbaro2.Status();

            barbaro1.LevelUP();
            barbaro1.Atacar(barbaro2);

            barbaro2.LevelUP();
            barbaro2.Revigorar();



           
        }

    }
}
