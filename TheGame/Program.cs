using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Scissors, paper, stone\n");
            Gamer pl1 = new AI();
            Gamer pl2 = new Persona();
            pl2.Name = "AutoUser";
            //Game game = new Game(pl1,pl2);
            Game game = new Game();
            game.Run();

            GameStats gameStats = game.GetStats();

            Console.WriteLine("\nGAME OVER!");
            Console.WriteLine("\nResults:");
            Console.WriteLine("Rounds played: {0}",gameStats.rounds);
            Console.WriteLine("Draws: {0}", gameStats.draws);
            Console.WriteLine("Player 1 wins: {0}", gameStats.playerOneWins );
            Console.WriteLine("Player 2 wins: {0}", gameStats.playerTwoWins);
            Console.ReadLine();

        }
    }
}
