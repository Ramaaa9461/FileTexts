using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BinaryText : MonoBehaviour
{

    List<GameObject> cubes = new List<GameObject>();
    GameObject currentCube;
    Vector3 position;
    private void Start()
    {
        ReadFile();
    }

    void ReadFile()
    {
        FileStream fs = File.OpenRead("C:/Users/Administrador/Desktop/FileTexts/Read_FileText/Read_FileText/bin/Debug/netcoreapp3.1/example.dat");


        BinaryReader br = new BinaryReader(fs);

        do
        {
        //    position = new Vector3(br.ReadSingle() * 10, br.ReadSingle() * 10, br.ReadSingle() * 10);

            currentCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            currentCube.transform.position = position;
            cubes.Add(currentCube);

        } while (position != new Vector3(1000, 1000, 0));

        br.Close();
        fs.Close();
    }


}
