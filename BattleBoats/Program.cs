using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleBoats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartNewGame();
            Console.ReadLine();
        }
        static void MenuOption()
        {

        }
        static void StartNewGame()
        {
            char[,] playerGameboard = new char[8,8];
            char[,] computerGameboard = new char[8, 8];

            InitializeGrid(playerGameboard);
        }
        static void InitializeGrid(char[,] Gameboard)
        {
            Gameboard = new char[8, 8];
            for (int i = 0; i < Gameboard.GetLength(0); i++)
            {
                for (int j = 0; j < Gameboard.GetLength(1); j++) 
                {
                    Gameboard[i, j] = '-';
                }
            }
            DisplayGrid(Gameboard);
        }
        static void DisplayGrid(char[,] Gameboard)
        {
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0;i < Gameboard.GetLength(0); i++)
            {
                Console.Write((i+1) + " ");
                for (int j = 0; j < Gameboard.GetLength(1); j++) 
                {
                    Console.Write(Gameboard[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
            