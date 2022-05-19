using System;
using System.IO;

namespace Read_FileText
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            float z;

            x = Convert.ToSingle( Console.ReadLine());
            y = Convert.ToSingle( Console.ReadLine());
            z = Convert.ToSingle( Console.ReadLine());

         
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            WriteBinaryFile(x,y,z);
        }
        static void ReadFile()
        {
            FileStream fs = File.OpenRead("C:/Users/Administrador/Desktop/Create_FileText/Create_FileText/Text.txt");

            StreamReader sr = new StreamReader(fs);

            Console.WriteLine(sr.ReadLine());

            sr.Close();
            fs.Close();
        }

        static void WriteBinaryFile(float x, float y, float z)
        {
            FileStream fs = File.OpenWrite("example.dat");

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(x);
            bw.Write(y);
            bw.Write(z);

            bw.Close();
            fs.Close();
        }

    }
}
