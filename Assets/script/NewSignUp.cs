using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class NewSignUp : MonoBehaviour
{
    public Text datosUsuario;
    string datos;
    string datosLeidos;
    string path = @"./Assets/Files/players.txt";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveFile()
    {
        datos = datosUsuario.text;
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(datos);
            }
        }
        else
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(datos);
            }
        }
    }

    public void Leer()
    {
        datos = datosUsuario.text;
        datosLeidos = File.ReadAllText(@"./Assets/Files/" + datos + ".txt");
        Debug.Log("Paso" + datosLeidos);
    }
}
