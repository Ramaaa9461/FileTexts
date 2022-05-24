using System;
using System.Collections.Generic;
using System.IO;


namespace Read_FileText
{
    class Program
    {

        static void Main(string[] args)
        {
            bool inGame = true;
            Character player = new Character('X', ConsoleColor.DarkYellow);
            List<Vector3> postions = new List<Vector3>();

            do
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    Input(player, cki, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow);

                    savePosition(cki, ConsoleKey.Spacebar, player.Position, ref postions);

                    Exit(cki, ConsoleKey.Escape, ref inGame);
                }
                //-----------------------------------------------------------------------------------------------------------
                player.DrawEntity();

            } while (inGame);

            foreach (Vector3 vec in postions)
            {
                WriteBinaryFile(vec);
            }

            Vector3 vector;
            vector.x = 1000;
            vector.y = 1000;
            WriteBinaryFile(vector);

        }
        static void ReadFile()
        {
            FileStream fs = File.OpenRead("C:/Users/Administrador/Desktop/Create_FileText/Create_FileText/Text.txt");

            StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadLine());

            sr.Close();
            fs.Close();
        }

        static void WriteBinaryFile(Vector3 vector)
        {
            FileStream fs = File.OpenWrite("example.dat");

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(vector.x);
            bw.Write(vector.y);
            bw.Write(vector.x / vector.y);

            bw.Close();
            fs.Close();
        }

        static void Input(Character character, ConsoleKeyInfo cki, ConsoleKey up, ConsoleKey down, ConsoleKey rigth, ConsoleKey left, int value = 1)
        {

            character.ClearCurrentPosition();

            if (cki.Key == up)
            {
                character.MoveUp(value);
            }

            if (cki.Key == down)
            {
                character.MoveDown(value);
            }

            if (cki.Key == rigth)
            {
                character.MoveRigth(value);
            }

            if (cki.Key == left)
            {
                character.MoveLeft(value);
            }

            character.setLimits();

        }

        static void savePosition(ConsoleKeyInfo cki, ConsoleKey keySave, Vector3 vec3, ref List<Vector3> pos)
        {
            if (cki.Key == keySave)
            {
                pos.Add(vec3);
            }
        }

        static void Exit(ConsoleKeyInfo cki, ConsoleKey keyExit, ref bool inGame)
        {
            if (cki.Key == keyExit)
            {
                inGame = false;
            }
        }
    }
}
