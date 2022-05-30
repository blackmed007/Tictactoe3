using System;
class display
{
    public void Game_board_empty()
    {
        Console.WriteLine("\t|\t|");
        Console.WriteLine("  - - - + - - - + - - - ");
        Console.WriteLine("\t|\t|");
        Console.WriteLine("  - - - + - - - + - - - ");
        Console.WriteLine("\t|\t|");

    }
    public void menu()
    {
        Console.WriteLine("1. New Game");
        Console.WriteLine("2. About Author");
        Console.WriteLine("3. Exit");
    }


}
class tic_tac_toe
{
    public static class global
    {
        public static char[] position_array = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    };

    static void Game_board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", global.position_array[0], global.position_array[1], global.position_array[2]);
        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", global.position_array[3], global.position_array[4], global.position_array[5]);
        Console.WriteLine("_ _ _+_ _ _+ _ _ _ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", global.position_array[6], global.position_array[7], global.position_array[8]);
        Console.WriteLine("     |     |      ");


    }
    static void Main()
    {
        display game = new display();

    main_menuback:
        global.position_array[0] = ' ';
        global.position_array[1] = ' ';
        global.position_array[2] = ' ';
        global.position_array[3] = ' ';
        global.position_array[4] = ' ';
        global.position_array[5] = ' ';
        global.position_array[6] = ' ';
        global.position_array[7] = ' ';
        global.position_array[8] = ' ';
        game.menu();

        int opt = 0;
        while (opt != 3)
        {
        menuback:
            Console.Write(">");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        game.Game_board_empty();

                        for (int i = 1; i <= 9; i++)
                        {
                            int index = 0;
                        jump1:
                        jump2:
                            if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                            {
                                Console.Write("X's move >");
                                index = Convert.ToInt32(Console.ReadLine());
                                if (index < 0 || index > 9)
                                {
                                    Console.WriteLine("Illgel move! try again.");
                                    goto jump1;
                                }

                                if (index >= 1 && index <= 9)
                                {

                                    if (global.position_array[index - 1] == ' ')
                                    {
                                        global.position_array[index - 1] = 'X';

                                        if (global.position_array[0] == 'X' && global.position_array[1] == 'X' && global.position_array[2] == 'X' ||
                                        global.position_array[3] == 'X' && global.position_array[4] == 'X' && global.position_array[5] == 'X' ||
                                        global.position_array[6] == 'X' && global.position_array[7] == 'X' && global.position_array[8] == 'X' ||
                                        global.position_array[0] == 'X' && global.position_array[3] == 'X' && global.position_array[6] == 'X' ||
                                        global.position_array[1] == 'X' && global.position_array[4] == 'X' && global.position_array[7] == 'X' ||
                                        global.position_array[2] == 'X' && global.position_array[5] == 'X' && global.position_array[8] == 'X' ||
                                        global.position_array[2] == 'X' && global.position_array[4] == 'X' && global.position_array[6] == 'X' ||
                                        global.position_array[0] == 'X' && global.position_array[4] == 'X' && global.position_array[8] == 'X')
                                        {
                                            Game_board();
                                            Console.WriteLine("X won!");
                                        jump:
                                            Console.WriteLine("[Press enter to return to main menu...]");
                                            ConsoleKeyInfo c = Console.ReadKey();
                                            if (c.Key == ConsoleKey.Enter)
                                            {
                                                goto main_menuback;
                                            }
                                            else
                                            {
                                                goto jump;
                                            }

                                        }


                                        Game_board();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Illgel move! try again.");
                                        goto jump1;
                                    }
                                }
                            }
                            else
                            {
                                Console.Write("O's move >");
                                index = Convert.ToInt32(Console.ReadLine());
                                if (index < 0 || index > 9)
                                {
                                    Console.WriteLine("Illgel move! try again.");
                                    goto jump2;
                                }
                                if (index >= 1 && index <= 9)
                                {

                                    if (global.position_array[index - 1] == ' ')
                                    {
                                        global.position_array[index - 1] = 'O';
                                        if (global.position_array[0] == 'O' && global.position_array[1] == 'O' && global.position_array[2] == 'O' ||
                                            global.position_array[3] == 'O' && global.position_array[4] == 'O' && global.position_array[5] == 'O' ||
                                            global.position_array[6] == 'O' && global.position_array[7] == 'O' && global.position_array[8] == 'O' ||
                                            global.position_array[0] == 'O' && global.position_array[3] == 'O' && global.position_array[6] == 'O' ||
                                            global.position_array[1] == 'O' && global.position_array[4] == 'O' && global.position_array[7] == 'O' ||
                                            global.position_array[2] == 'O' && global.position_array[5] == 'O' && global.position_array[8] == 'O' ||
                                            global.position_array[2] == 'O' && global.position_array[4] == 'O' && global.position_array[6] == 'O' ||
                                            global.position_array[0] == 'O' && global.position_array[4] == 'O' && global.position_array[8] == 'O')
                                        {
                                            Game_board();
                                            Console.WriteLine("O won!");
                                        jump0:
                                            Console.WriteLine("[Press enter to return to main menu...]");
                                            ConsoleKeyInfo c = Console.ReadKey();
                                            if (c.Key == ConsoleKey.Enter)
                                            {
                                                goto main_menuback;
                                            }
                                            else
                                            {
                                                goto jump0;
                                            }

                                        }
                                        Game_board();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Illgel move! try again.");
                                        goto jump2;
                                    }

                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Abdelhamid, student at wsb , 22 years old ");
                        Console.WriteLine("[Press enter to return to main menu...]");
                        ConsoleKeyInfo cc = Console.ReadKey();
                        if (cc.Key == ConsoleKey.Enter)
                        {
                            goto main_menuback;
                        }
                        break;
                    }
                case 3:
                    {
                        char ch;
                        Console.WriteLine("Are you sure you want to quit? [y/n]");
                        Console.Write(">");
                        ch = Convert.ToChar(Console.ReadLine());
                        if (ch == 'y')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto main_menuback;
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Input! Please enter again.");
                    goto menuback;
            }
        }
        Console.WriteLine("Game Over!");
    }
}