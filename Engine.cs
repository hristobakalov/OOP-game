namespace OOP_Teamwork___Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Engine
    {
        public static void GameSettings(int gameFieldWidth, int gameFieldHeight)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = gameFieldWidth;
            Console.WindowHeight = gameFieldHeight;
            Console.CursorVisible = false;
            Console.Title = "Totally not a virus";
        }
        //private Player playerTest = new Player("Pesho", 100, new List<Ability>(), new Point(0, 0));
        public static void StartGame() 
        {
            Player playerTest = new Player("Pesho", 100, new List<Ability>(), new Point());
            while (true)
            {
                CheckForPressedKey(playerTest);
            }
        }

        private static void CheckForPressedKey(Player player)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    player.MovePlayer(0, -1);
                    //CleanBattleField("left");
                    //DrawGameField();
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    player.MovePlayer(0, 1);
                    //CleanBattleField("right");
                    //DrawGameField();
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    player.MovePlayer(-1, 0);
                    //CleanBattleField("up");
                    //DrawGameField();

                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    player.MovePlayer(1, 0);
                    //CleanBattleField("down");
                    //DrawGameField();
                }
                //else if (pressedKey.Key == ConsoleKey.E && gamePause == false)
                //{
                //    Console.BackgroundColor = ConsoleColor.Black;
                //    Console.Clear();
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine("Good bye!");
                //    Console.ForegroundColor = ConsoleColor.Gray;
                //    Environment.Exit(0);
                //}
                //else if (pressedKey.Key == ConsoleKey.P)
                //{
                //    if (gamePause)
                //    {
                //        gamePause = false;
                //    }
                //    else
                //    {
                //        gamePause = true;
                //        while (gamePause)
                //        {
                //            CheckForPressedKey();
                //        }
                //    }
                //}
                //else if (pressedKey.Key == ConsoleKey.S)
                //{
                //    SaveGame();
                //}
                //else if (pressedKey.Key == ConsoleKey.L)
                //{

                //    LoadSavedGame();
                //    CleanBattleField();
                //    DrawGameField();
                //    //CreateBonuses();
                //}
                //else if (pressedKey.Key == ConsoleKey.B)
                //{
                //    time += 20;
                //}
                //else if (pressedKey.Key == ConsoleKey.N)
                //{
                //    time -= 20;
                //}
                //else if (pressedKey.Key == ConsoleKey.T)
                //{
                //    torchLight++;
                //}
                //else if (pressedKey.Key == ConsoleKey.R)
                //{
                //    torchLight--;
                //    CleanBattleField();
                //    DrawGameField();
                //}
                
             
            }
         
        }
         /* private static void MovePlayer(int rowChange, int colChange)
        {
            int newRowAfterMove = playerCordinates[0] + rowChange;
            int newColAfterMove = playerCordinates[1] + colChange;
            bool bonusGot = false;
            if (newRowAfterMove >= 0 && newColAfterMove >= 0 && newRowAfterMove < gameFieldHeight && newColAfterMove < gameFieldWidth && gameField[newRowAfterMove, newColAfterMove] != 1)
            {
                if (gameField[newRowAfterMove, newColAfterMove] == 4)
                {
                    score += (int)(100 * scoreMultiplier);
                    time += 5;
                    gameField[newRowAfterMove, newColAfterMove] = 0;
                    bonusGot = true;
                    if (bonusesGot < bonusToPassLevel)
                    {
                        bonusesGot++;
                    }
                }
                if (gameField[newRowAfterMove, newColAfterMove] == 5)
                {
                    if (bonusesGot == bonusToPassLevel)
                    {
                        gameField[newRowAfterMove, newColAfterMove] = 0;
                        Console.Clear();
                        bonuses.Clear();
                        playerCordinates[0] = 0;
                        playerCordinates[1] = 0;
                        scoreMultiplier += 0.2;
                        level++;
                        bonusesGot = 0;
                        bonusToPassLevel += 5;
                        SwitchMusic("off");
                        backgroundMusic = true;
                        StartGame();
                    }
                    else
                    {
                        newRowAfterMove = playerCordinates[0];
                        newColAfterMove = playerCordinates[1];
                    }
                }
                ConsoleWrite(playerCordinates[1], playerCordinates[0], " ", ConsoleColor.White, ConsoleColor.White);
                playerCordinates[0] = newRowAfterMove;
                playerCordinates[1] = newColAfterMove;
                if (bonusGot)
                {
                    foreach (var item in bonuses)
                    {
                        if (item.X == playerCordinates[0] && item.Y == playerCordinates[1])
                        {
                            bonuses.Remove(item);
                            break;
                        }
                    }
                    CreateBonuses();
                    //PrintBonuses(bonuses);
                    gameField[newRowAfterMove, newColAfterMove] = 0;
                    bonusGot = false;
                }
                ConsoleWrite(playerCordinates[1], playerCordinates[0], playerSymbol.ToString(), ConsoleColor.Blue, ConsoleColor.White);
            }
        }
         */
    }
}
