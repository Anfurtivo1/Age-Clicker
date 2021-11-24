using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase.Firestore;
public class Utils : MonoBehaviour
{
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
        db.Collection("Ranking").Document("Nuevo jugador").SetAsync(puntuacion).ContinueWith(task =>{
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



}
