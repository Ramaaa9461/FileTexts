﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Read_FileText
{
    class Entity
    {
        protected char letter;
        protected ConsoleColor color;
        protected Vector3 position = new Vector3();

        private int upLimit = 1;
        private int downLimit = Console.WindowHeight - 1;
        private int leftLimit = 1;
        private int rigthLimit = Console.WindowWidth - 1;

        public Vector3 Position
        {
            private set { position = value; }
            get { return position; }
        }
        public ConsoleColor Color
        {
            private set { color = value; }
            get { return color; }
        }
        public Entity(char letter, ConsoleColor color)
        {
            RespawnRandomPosition();
            this.letter = letter;
            this.color = color;
        }

        public void RespawnRandomPosition()
        {
            Random random = new Random();
            position.x = random.Next(leftLimit, rigthLimit);
            position.y = random.Next(upLimit, downLimit);
        }

        public void setLimits()
        {
            if (position.x > rigthLimit)
            {
                position.x = leftLimit;
            }

            if (position.x < leftLimit)
            {
                position.x = rigthLimit;
            }

            if (position.y > downLimit)
            {
                position.y = upLimit;
            }

            if (position.y < upLimit)
            {
                position.y = downLimit;
            }
        }
        public void ClearCurrentPosition()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(' ');
        }
        public void DrawEntity()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(letter);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
