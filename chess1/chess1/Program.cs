﻿using System;

namespace chess1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FEN_StartPostition = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
            chessBoard Board = new chessBoard(FEN_StartPostition);
            Board.Draw();
        }
    }

    class chessBoard
    {
        public string[] allPices = new string[64];


        public chessBoard(string FEN)
        {
            string[] FENsplit = FEN.Split("/");
            int placeValue = 0;
            for (int line = 0; line < FENsplit.Length; line++)
            {
                //Console.WriteLine("line num:" + line.ToString() + "\nFEN:" + FENsplit[line]);
                for (int characterPlace = 0; characterPlace < FENsplit[line].Length; characterPlace++)
                {
                    int number;
                    if (int.TryParse(FENsplit[line][characterPlace].ToString(), out number))
                    {
                        for (int i = 0; i < number; i++)
                        {
                            allPices[placeValue] = "#";
                            placeValue++;
                        }
                    }
                    else
                    {
                        allPices[placeValue] = FENsplit[line][characterPlace].ToString();
                        placeValue++;
                    }
                }
            }
        }
        public void Draw()
        {
            for (int i = 0; i < allPices.Length; i++)
            {
                if ((i + 1) % 8 == 0)
                {
                    Console.Write(allPices[i] + "\n");
                }
                else
                {
                    Console.Write(allPices[i]);
                }
            }
        }
    }





    class knight
    {
        char chessNotation = 'N';
        public bool colour;
        public int current_x;
        public int current_y;
    }

    class king
    {
        char chessNotation = 'K';
        public bool colour;
        public int current_x;
        public int current_y;
    }
    class queen
    {
        char chessNotation = 'Q';
        public bool colour;
        public int current_x;
        public int current_y;
    }

    class bishop
    {
        char chessNotation = 'B';
        public bool colour;
        public int current_x;
        public int current_y;
    }

    class rook
    {
        char chessNotation = 'R';
        public bool colour;
        public int current_x;
        public int current_y;
    }

    class pawn
    {
        char chessNotation = 'p';
        public bool colour;
    }
}