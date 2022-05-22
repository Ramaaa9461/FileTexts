using System;
using System.Collections.Generic;
using System.Text;

namespace Read_FileText
{
    class Character : Entity
    {

        public Character(char letter, ConsoleColor color) : base(letter, color)
        {
        }
         

        public void MoveUp(int value = 1)
        {
            position.y -= value;
        }
        public void MoveDown(int value = 1)
        {
            position.y += value;
        }
        public void MoveRigth(int value = 1)
        {
            position.x += value;
        }
        public void MoveLeft(int value = 1)
        {
            position.x -= value;
        }
    }


}
