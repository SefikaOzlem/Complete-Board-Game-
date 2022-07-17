using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 0;
            y = 0;
            int turn = 1;
            string name = "";
            char board11 = ' ';
            char board12 = ' ';
            char board13 = ' ';
            char board21 = ' ';
            char board22 = ' ';
            char board23 = ' ';
            char board31 = ' ';
            char board32 = ' ';
            char board33 = ' ';
            int piece = 0;
            string name1 = "Ali";
            string name2 = "Selin";
            string name3 = "Utku";
            int turn1 = 8;
            int turn2 = 16;
            int turn3 = 25;
           

            do
            {
                Random rand = new Random();
                piece = rand.Next(1, 6);
                Console.WriteLine("------Turn " + turn + "-------");
                Console.WriteLine();
                Console.WriteLine("   1 2 3               Generatad Piece ");
                Console.WriteLine(" + - - - + ");
                Console.WriteLine("1| " + board11 + " " + board21 + " " + board31 + " | ");
                Console.WriteLine("2| " + board12 + " " + board22 + " " + board32 + " | ");
                Console.WriteLine("3| " + board13 + " " + board23 + " " + board33 + " | ");
                Console.WriteLine(" + - - - + ");
                Console.WriteLine();
                Console.WriteLine();
                if (piece == 1)
                {
                    Console.SetCursorPosition(28, 3);
                    Console.Write("X  ");

                }
                else if (piece == 2)
                {
                    Console.SetCursorPosition(28, 3);
                    Console.Write("X X      ");

                }
                else if (piece == 3)
                {
                    Console.SetCursorPosition(28, 3);
                    Console.Write("X X X     ");

                }
                else if (piece == 4)
                {
                    Console.SetCursorPosition(28, 3);
                    Console.Write("X       ");
                    Console.SetCursorPosition(28, 4);
                    Console.Write("X       ");
                }
                else if (piece == 5)
                {
                    Console.SetCursorPosition(28, 3);
                    Console.Write("X       ");
                    Console.SetCursorPosition(28, 4);
                    Console.Write("X       ");
                    Console.SetCursorPosition(28, 5);
                    Console.Write("X       ");
                }
                Console.SetCursorPosition(1, 12);
                Console.Write("x coordinate :");
                x = Convert.ToInt16(Console.ReadLine());
                Console.Write(" y coordinate :");
                y = Convert.ToInt16(Console.ReadLine());
                if (piece == 1 & x == 1 & y == 1 & board11 == ' ')
                {
                    Console.SetCursorPosition(3, 7);
                    Console.Write("X");
                    board11 = 'X';
                    turn = turn + 1;

                }
                else if (piece == 1 & x == 1 & y == 2 & board12 == ' ')
                {
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X");
                    board12 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 1 & y == 3 & board13 == ' ')
                {
                    Console.SetCursorPosition(3, 9);
                    Console.Write("X");
                    board13 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 2 & y == 1 & board21 == ' ')
                {
                    Console.SetCursorPosition(5, 7);
                    Console.Write("X");
                    board21 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 2 & y == 2 & board22 == ' ')
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("X");
                    board22 = 'X';
                    turn =turn + 1;
                }
                else if (piece == 1 & x == 2 & y == 3 & board23 == ' ')
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("X");
                    board23 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 3 & y == 1 & board31 == ' ')
                {
                    Console.SetCursorPosition(7, 7);
                    Console.Write("X");
                    board31 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 3 & y == 2 & board32 == ' ')
                {
                    Console.SetCursorPosition(7, 8);
                    Console.Write("X");
                    board32 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 1 & x == 3 & y == 3 & board33 == ' ')
                {
                    Console.SetCursorPosition(7, 9);
                    Console.Write("X");
                    board33 = 'X';
                    turn =turn + 1;
                }
                else if (piece == 2 & x == 1 & y == 1 & board11 == ' ' & board21 == ' ')
                {
                    Console.SetCursorPosition(3, 7);
                    Console.Write("X X");
                    board11 = 'X';
                    board21 = 'X';
                    turn =turn + 1;
                }
                else if (piece == 2 & x == 1 & y == 2 & board12 == ' ' & board22 == ' ')
                {
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X X");
                    board12 = 'X';
                    board22 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 2 & x == 1 & y == 3 & board13 == ' ' & board23 == ' ')
                {
                    Console.SetCursorPosition(3, 9);
                    Console.Write("X X");
                    board13 = 'X';
                    board23 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 2 & x == 2 & y == 1 & board21 == ' ' & board31 == ' ')
                {
                    Console.SetCursorPosition(5, 7);
                    Console.Write("X X");
                    board21 = 'X';
                    board31 = 'X';
                    turn =turn + 1;
                }
                else if (piece == 2 & x == 2 & y == 2 & board22 == ' ' & board32 == ' ')
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("X X");
                    board22 = 'X';
                    board32 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 2 & x == 2 & y == 3 & board23 == ' ' & board33 == ' ')
                {
                    Console.SetCursorPosition(5, 9);
                    Console.Write("X X");
                    board23 = 'X';
                    board33 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 3 & x == 1 & y == 1 & board11 == ' ' & board21 == ' ' & board31 == ' ')
                {
                    Console.SetCursorPosition(3, 7);
                    Console.Write("X X X");
                    board11 = 'X';
                    board21 = 'X';
                    board31 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 3 & x == 1 & y == 2 & board12 == ' ' & board22 == ' ' & board32 == ' ')
                {
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X X X");
                    board12 = 'X';
                    board22 = 'X';
                    board32 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 3 & x == 1 & y == 3 & board13 == ' ' & board23 == ' ' & board33 == ' ')
                {
                    Console.SetCursorPosition(3, 9);
                    Console.Write("X X X");
                    board13 = 'X';
                    board23 = 'X';
                    board33 = 'X';
                    turn = turn + 1;

                }
                else if (piece == 4 & x == 1 & y == 1 & board11 == ' ' & board12 == ' ')
                {
                    Console.SetCursorPosition(3, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X");
                    board11 = 'X';
                    board12 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 4 & x == 1 & y == 2 & board12 == ' ' & board13 == ' ')
                {
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(3, 9);
                    Console.Write("X");
                    board12 = 'X';
                    board13 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 4 & x == 2 & y == 1 & board21 == ' ' & board22 == ' ')
                {
                    Console.SetCursorPosition(5, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("X");
                    board21 = 'X';
                    board22 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 4 & x == 2 & y == 2 & board22 == ' ' & board23 == ' ')
                {
                    Console.SetCursorPosition(5, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(5, 9);
                    Console.Write("X");
                    board22 = 'X';
                    board23 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 4 & x == 3 & y == 1 & board31 == ' ' & board32 == ' ')
                {
                    Console.SetCursorPosition(7, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(7, 8);
                    Console.Write("X");
                    board31 = 'X';
                    board32 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 4 & x == 3 & y == 2 & board32 == ' ' & board33 == ' ')
                {
                    Console.SetCursorPosition(7, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(7, 9);
                    Console.Write("X");
                    board32 = 'X';
                    board33 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 5 & x == 1 & y == 1 & board11 == ' ' & board12 == ' ' & board13 == ' ')
                {
                    Console.SetCursorPosition(3, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(3, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(3, 9);
                    Console.Write("X");
                    board11 = 'X';
                    board12 = 'X';
                    board13 = 'X';
                    turn = turn + 1;

                }
                else if (piece == 5 & x == 2 & y == 1 & board21 == ' ' & board22 == ' ' & board23 == ' ')
                {
                    Console.SetCursorPosition(5, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(5, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(5, 9);
                    Console.Write("X");
                    board21 = 'X';
                    board22 = 'X';
                    board23 = 'X';
                    turn = turn + 1;
                }
                else if (piece == 5 & x == 3 & y == 1 & board31 == ' ' & board32 == ' ' & board33 == ' ')
                {
                    Console.SetCursorPosition(7, 7);
                    Console.Write("X");
                    Console.SetCursorPosition(7, 8);
                    Console.Write("X");
                    Console.SetCursorPosition(7, 9);
                    Console.Write("X");
                    board31 = 'X';
                    board32 = 'X';
                    board33 = 'X';
                    turn = turn + 1;

                }
                else if (x==0 & y==0)
                {
                    turn = turn + 1;
                }
                else
                {
                    Console.WriteLine("please enter another coordinate(s)");
                    turn = turn + 1;
                }
               Console.Clear();
            } while (board11 == ' ' | board12 == ' ' | board13 == ' ' | board21 == ' ' | board22 == ' ' | board23 == ' ' | board31 == ' ' | board32 == ' ' | board33 == ' ');
            Console.WriteLine("------ COMPLETED-------");
            Console.WriteLine();
            Console.WriteLine(" + - - - + ");
            Console.WriteLine("1| " + board11 + " " + board21 + " " + board31 + " | ");
            Console.WriteLine("2| " + board12 + " " + board22 + " " + board32 + " | ");
            Console.WriteLine("3| " + board13 + " " + board23 + " " + board33 + " | ");
            Console.WriteLine(" + - - - + ");
            Console.WriteLine("Please Enter A Name");
               name = Console.ReadLine();
            Console.Clear();
            turn--;
               Console.WriteLine("      HİGH  SCORE TABLE  ");
               Console.WriteLine("     -------------------");
               Console.WriteLine("      NAME           TURN   ");
            if (turn <= 8)
            {
                Console.WriteLine("1." +name   );
                Console.WriteLine("2."+name1 + "                 " + turn1);
                Console.WriteLine("3."+name2 + "               " + turn2);
                Console.SetCursorPosition(22, 3);
                Console.WriteLine(turn);
            }
            else if (turn > 8 && turn <= 16)
            {
                Console.WriteLine("1"+name1+"                  "+turn1);
                Console.WriteLine("2." +name );
                Console.WriteLine("3."+name2+"               "+turn2);
                Console.SetCursorPosition(22, 4);
                Console.WriteLine(turn);
            }
            else if (turn > 16 && turn <= 25)
            {
                Console.WriteLine("1." + name1 + "              " + turn1);
                Console.WriteLine("2." + name2 + "            " + turn2);
                Console.WriteLine("3." + name  );
                Console.SetCursorPosition(22, 5);
                Console.WriteLine(turn);
            }
            else if (turn >= 25)
            {
                Console.WriteLine("Try Again");
            }
              Console.Read();
        }
    }
}
