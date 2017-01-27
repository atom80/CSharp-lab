using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame {
    public enum Decision {
        Scissors = 1,
        Paper = 2,
        Stone = 3
    };

    abstract class User {
        public string Name { get; set; }
    }

    sealed class Guest : User {
        public Guest() {
            this.Name = "Anonymous guest";
        }
    }

    interface IShowable {
        string ShowName();
    }

    class Gamer : User, IShowable {
        public virtual Decision MakeDecision() {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return (Decision)rnd.Next(1, 4);
        }

        public string ShowName() {
            throw new NotImplementedException();
        }
    }

    class AI : Gamer {
        public AI() {
            this.Name = "AI";
        }
    }

    class Persona : Gamer {
        public override Decision MakeDecision() {
            Console.Write("\n{0}, your move(1-scissors,2-paper,3-stone): ", this.Name);
            Decision decision = (Decision)Convert.ToInt32(Console.ReadLine());
            return decision;
        }
    }

    struct GameStats {
        public int rounds;
        public int draws;
        public int playerOneWins;
        public int playerTwoWins;
    }

    class Game {
        private Gamer playerOne;
        private Gamer playerTwo;
        private GameStats gameStats;
        private void initStats() {
            this.gameStats.rounds = 0;
            this.gameStats.draws = 0;
            this.gameStats.playerOneWins = 0;
            this.gameStats.playerTwoWins = 0;
        }
        public Game(Gamer playerOne, Gamer playerTwo) {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            initStats();
        }

        public Game() {
            initStats();
            int playerType = 0;
            do {
                Console.Write("Player 1 (1-you, 2-AI): ");
                playerType = Convert.ToInt32(Console.ReadLine());
            } while ((playerType != 1) && (playerType != 2)); // RRR

            switch (playerType) {
                case 1:
                playerOne = new Persona();
                Console.Write("\nPlayer 1 name: ");
                playerOne.Name = Console.ReadLine();
                break;
                case 2:
                playerOne = new AI();
                break;
                default:
                break;
            }
            do {
                Console.Write("Player 2 (1-you, 2-AI): ");
                playerType = Convert.ToInt32(Console.ReadLine());
            } while ((playerType != 1) & (playerType != 2)); // RRR

            switch (playerType) {
                case 1:
                playerTwo = new Persona();
                Console.Write("\nPlayer 2 name: ");
                playerTwo.Name = Console.ReadLine();
                break;
                case 2:
                playerTwo = new AI();
                break;
                default:
                break;
            }
        }

        public GameStats GetStats() {
            return gameStats;
        }
        public void Run() {
            initStats();
            bool oneMoreTime = false;
            Decision decisionOne, decisionTwo;
            string isRepeat;
            do {
                gameStats.rounds++;
                Console.WriteLine("Round {0}: {1} vs. {2}", gameStats.rounds, playerOne.Name, playerTwo.Name);
                decisionOne = playerOne.MakeDecision();
                decisionTwo = playerTwo.MakeDecision();
                Console.WriteLine("<Player 1>: {0}", decisionOne);
                Console.WriteLine("<Player 2>: {0}", decisionTwo);
                if (decisionOne == decisionTwo) {
                    gameStats.draws++;
                    Console.WriteLine("Draw!");
                } else
                    if (decisionOne > decisionTwo) {
                        gameStats.playerOneWins++;
                        Console.WriteLine("{0} (Player 1) wins!", playerOne.Name);
                    } else {
                        gameStats.playerTwoWins++;
                        Console.WriteLine("{0} (Player 2) wins!", playerTwo.Name);
                    }
                Console.Write("One more time?(y/n)");
                isRepeat = Console.ReadLine();
                oneMoreTime = (isRepeat == "y") || (isRepeat == "Y");
            } while (oneMoreTime);

        }

    }
}
