using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoginSystem.Models;

namespace LoginSystem
{
    public class LoginScript : MonoBehaviour
    {
        string userPass;
        string passCorrecto;
        public Text passwordIngreso;
        public Text textoModal;
        public GameObject modalMje;
        public Jugador jugador;

        // Start is called before the first frame update
        void Start()
        {
            passCorrecto = "1234";
            modalMje.SetActive(false);
            jugador = new Jugador() { Id = "uno", Edad = 25, Nombre = "marcelo" };
        }
        // Update is called once per frame
        void Update()
        {
        
        }
        public void validarPass()
        {
            Debug.Log(jugador.Nombre);
            userPass = passwordIngreso.text;
            if (passCorrecto == userPass)
            {
                textoModal.text = "Ingreso";
                modalMje.SetActive(true);
            }
            else
            {
                textoModal.text = "Password Incorrecto";
                modalMje.SetActive(true);
            }
        }
        public void closeModal()
        {
            modalMje.SetActive(false);
        }
    }
}
