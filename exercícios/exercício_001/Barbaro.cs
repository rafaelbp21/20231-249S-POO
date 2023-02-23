using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Barbaro.Sistema_Barbaro
{
    public class Classe
    {
        public string? Nome;
        public int Forca = 25;        
        public int Vitalidade = 23;
        public int Inteligencia = 7;
        public int Destreza = 15;
        public float Vida = 34.0f;
        public int maxVida = 34;
        public int Mana = 10;
        public int maxMana = 10;
        public int Nivel = 1;
        

        public void Status()
        {
            Console.WriteLine($"O Nivel do {Nome} é: {Nivel}");
            Console.WriteLine($"A Forca do {Nome} é: {Forca}");
            Console.WriteLine($"A Vitalidade do {Nome} é: {Vitalidade}");
            Console.WriteLine($"A Inteligencia do {Nome} é: {Inteligencia}");
            Console.WriteLine($"A Destreza do {Nome} é: {Destreza}");
            Console.WriteLine($"A Vida do {Nome} é: {Vida}");
            Console.WriteLine($"A maxVida do {Nome} é: {maxVida}");
            Console.WriteLine($"A Mana do {Nome} é: {Mana}");
            Console.WriteLine($"A maxMana do {Nome} é: {maxMana}");
        }
        public void LevelUP()
        {
            Nivel += 1;
            Forca += 5;
            Vitalidade += 3;            
            Inteligencia += 1;
            Destreza += 2;
            maxVida += ((Vitalidade*3)/2);
            Mana += 2;
            maxMana += 2;

            Console.WriteLine($"Apos a evolução o Nivel do {Nome} é: {Nivel}");
            Console.WriteLine($"A Forca do {Nome} é: {Forca}");
            Console.WriteLine($"A Vitalidade do {Nome} é: {Vitalidade}");
            Console.WriteLine($"A Inteligencia do {Nome} é: {Inteligencia}");
            Console.WriteLine($"A Destreza do {Nome} é: {Destreza}");
            Console.WriteLine($"A maxVida do {Nome} é: {maxVida}");
            Console.WriteLine($"A Mana do {Nome} é: {Mana}");
            Console.WriteLine($"A maxMana do {Nome} é: {maxMana}");
            
        }
        public void Atacar(Classe inimigo)
        {
            float ataque = (Forca / 2.0f) + (Destreza / 3.0f) + (Inteligencia / 5.0f);
            if (Mana >= 2)
            {
                inimigo.Vida -= ataque;
                Mana -= 2;
                Console.WriteLine($"Apos o ataque de {ataque} a Vida do {inimigo.Nome} é: {inimigo.Vida}");
                Console.WriteLine($"E o {Nome} utilizou 2 de Mana, ficando um total de: {Mana}");
            }
            else
            {
                Console.WriteLine($"A Mana do {Nome} é insuficiente para o ataque!");
            }
        }
        public void Revigorar()
        {

            float vida = (Vida * 2.0f / 3.0f);
            if (maxVida <= vida)
            {
                Vida += vida;
                Console.WriteLine($"Apos revigorar a Vida do {Nome} foi para: {Vida}");
            }
            else
            {
                Console.WriteLine($"A Vida do {Nome} não pode ultrapassar a maxVida de {maxVida}!");
            }

            int mana = (Mana * 1 / 3);
                Mana += mana;
                Console.WriteLine($"Apos revigorar a Mana do {Nome} foi para: {Mana}");
         
        }

    }
}
