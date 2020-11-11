using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SignUp : MonoBehaviour
{
    public Text primerInputTest;
    string texto;
    string textRead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData()
    {
        texto = primerInputTest.text;
        //File.WriteAllText(@"./Assets/Files/"+texto+".txt", texto);
        textRead = File.ReadAllText(@"./Assets/Files/" + texto + ".txt");
        Debug.Log(textRead);

    }
}
