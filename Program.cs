using System;
using System.Security.Cryptography.X509Certificates;
using investigation_game.Game;


namespace investigationGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Game NewGame = new Game();
            NewGame.StartGame();
        }
    }
}