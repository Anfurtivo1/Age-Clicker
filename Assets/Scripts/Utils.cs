using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase.Firestore;
using System;

public class Utils : MonoBehaviour
{
    public Text cantidadPuntosAscension;
    public Text recursosTotales;
    public Text nombreJugador;
    FirebaseFirestore db;
    Dictionary<string, object> puntuacion;

    public void pasarNivel()
    {
        puntuacion = new Dictionary<string, object>
        {
            {"Recursos Totales",recursosTotales.text.ToString() },
            {"Nombre del jugador",nombreJugador.text.ToString() },
        };
        db = FirebaseFirestore.DefaultInstance;
        Guid myuuid = Guid.NewGuid();
        Debug.Log(myuuid);
        db.Collection("Ranking").Document(myuuid.ToString()).SetAsync(puntuacion).ContinueWith(task =>{
            if (task.IsCompleted)
            {
                Debug.Log("Ranking guardado");
            }
            else
            {
                Debug.Log("Ranking no guardado");
            }
        });
        int totales = int.Parse(recursosTotales.text.ToString());
        if (totales >= 3079)
        {
            SceneManager.LoadScene("Scene 2");
        }
        else
        {
            Debug.Log("No puedes acceder a ese nivel aún");
        }
        
    }

    public void ascender()
    {
        int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());
        PlayerPrefs.SetInt("puntosAscension", puntosAscension);
        Debug.Log("Se van a guardar: " + puntosAscension);
        SceneManager.LoadScene("Scene 2", LoadSceneMode.Additive);

        int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
        Debug.Log("Se han cargado: " + nuevosPuntosAscension);
        Text textoPuntosAscension = GameObject.Find("Numero de puntos de ascension").GetComponent<Text>();
        EdificiosManager.instanciaEdificiosManager.numeroPuntosPrestigio.text = "" + puntosAscension;

        //EdificiosManager.instanciaEdificiosManager.prestigio = puntosAscension;

    }

}
