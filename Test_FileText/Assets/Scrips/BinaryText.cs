using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BinaryText : MonoBehaviour
{

    [SerializeField] GameObject cube;

    private void Start()
    {
        ReadFile();
    }

    void ReadFile()
    {
        FileStream fs = File.OpenRead("C:/Users/Administrador/Desktop/Read_FileText/Read_FileText/bin/Debug/netcoreapp3.1/example.dat");

        BinaryReader br = new BinaryReader(fs);

        cube.transform.position = new Vector3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());

        br.Close();
        fs.Close();
    }


}
