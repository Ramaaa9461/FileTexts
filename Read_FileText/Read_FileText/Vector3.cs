using System;
using System.Collections.Generic;
using System.Text;

namespace Read_FileText
{
    struct Vector3
    {
        public int x;
        public int y;

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x == rhs.x && lhs.y == rhs.y;
        }
        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return lhs.x != rhs.x || lhs.y != rhs.y;
        }
    }
}
