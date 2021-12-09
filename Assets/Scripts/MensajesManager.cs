using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MensajesManager : MonoBehaviour
{
    public GameObject mensajePopup;
    public Animator animador;
    public Text mensajeTexto;
    public GameObject panelRanking;

    public void mostrarMensaje(string mensaje)
    {
        panelRanking.SetActive(true);
        mensajeTexto.text = mensaje;
        //animador.SetTrigger("Mostrar");
    }
    
}
