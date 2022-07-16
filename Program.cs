using System;
using Projeto1GFT.src.Models;


namespace projeto1gft
{
    class Program
    {

        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Zezinha", 76, "Wizard");
            Archer archer = new Archer("Robinho", 78, "Archer");
            Beserker beserker = new Beserker("Khorno", 81, "Beserker");
            Knight knight = new Knight("Manaus", 81, "Knight");
            Priest priest = new Priest("Elise", 80, "Priest");

        
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(archer.Attack(8));
            Console.WriteLine(beserker.Attack(8));
            Console.WriteLine(knight.Attack());
            Console.WriteLine(priest.Attack(6));
        
        }

    }
}




