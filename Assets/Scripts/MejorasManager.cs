using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MejorasManager : MonoBehaviour
{
    public Text recursosActuales;


    public void comprarMejoraTier1()
    {
        int recursoActual = int.Parse(recursosActuales.text.ToString());

        if (recursoActual >= 100)
        {
            Debug.Log("Has comprado la mejora 1");
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 5;
            Debug.Log("El poder de los edificios 1 ahora es de "+ EdificiosManager.instanciaEdificiosManager.poderEdificio1);
            boton.interactable = false;
        }
        else
        {
            Debug.Log("No has podido comprar la mejora 1");
        }

    }

}
