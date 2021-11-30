using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MensajesManager : MonoBehaviour
{
    public GameObject mensajePopup;
    public Animator animador;
    public TMP_Text mensajeTexto;

    public void mostrarMensaje(string mensaje)
    {
        mensajePopup.SetActive(true);
        mensajeTexto.text = mensaje;
        animador.SetTrigger("mostrar");
    }
    
}
