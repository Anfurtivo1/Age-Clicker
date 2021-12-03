using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase.Firestore;
using System;
using System.Threading.Tasks;
using Firebase.Extensions;

public class Utils : MonoBehaviour
{
    public Text cantidadPuntosAscension;
    public Text recursosTotales;
    public Text nombreJugador;
    public GameObject panel;
    private string txt;
    public InputField input;
    public Button botonAceptar;
    static FirebaseFirestore db;
    Dictionary<string, object> puntuacion;
    public String mensajeMostrar;
    private MensajesManager mensaje;
    private bool accesoFirebase = false;

    public void Start()
    {
        Button btn = botonAceptar.GetComponent<Button>();
        btn.onClick.AddListener(cambiarNombre);
        //mostrarMensaje();
        if (SceneManager.GetActiveScene().name == "Scene 2")
        {
            mensaje = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MensajesManager>();

        }
    }

    public void cambiarNombre()
    {
        nombreJugador.text = input.text;
        panel.SetActive(false);
    }

    public void mostrarPanelCambiarNombre()
    {
        panel.SetActive(true);
    }

    public void mostrarMensaje()
    {
        if (accesoFirebase)
        {
            try
            {
                obtenerJugadoresRanking();
                //mensaje.mostrarMensaje(mensajeMostrar);
            }
            catch (Exception e)
            {

                Debug.Log("El error es: "+e.Message);
            }
            
        }

        
    }

    public void pasarNivel()
    {
        int totales = int.Parse(recursosTotales.text.ToString());

        if (totales >= 3000)
        {

            escribirJugadorRanking();

            int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());
            int recursoTotal = int.Parse(recursosTotales.text.ToString());

            PlayerPrefs.SetInt("puntosAscension", puntosAscension);
            PlayerPrefs.SetInt("recursosTotales", recursoTotal);

            //Debug.Log("Se van a guardar: " + puntosAscension+" puntos de ascension");
            //Debug.Log("Se van a guardar: " + recursoTotal+" recursos totales");

            SceneManager.LoadScene("Scene 2");

            int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
            int nuevosRecursosTotales = PlayerPrefs.GetInt("recursosTotales");

            //Debug.Log("Se han cargado: " + nuevosPuntosAscension +" puntos de ascension");
            //Debug.Log("Se han cargado: " + nuevosRecursosTotales + " recursos totales");

            //refrescarPuntosAscension(nuevosPuntosAscension);
            //refrescarRecursosTotales(nuevosRecursosTotales);
        }
        else
        {
            Debug.Log("No puedes acceder a ese nivel aún");
        }
        
    }

    private void obtenerJugadoresRanking()
    {
        db = FirebaseFirestore.DefaultInstance;

        CollectionReference usersRef = db.Collection("Ranking");
        usersRef.GetSnapshotAsync().ContinueWithOnMainThread(task => {
        QuerySnapshot snapshot = task.Result;
        foreach (DocumentSnapshot document in snapshot.Documents)
        {
            //Console.WriteLine("Jugador: {0}", document.Id);
            Dictionary<string, object> documentDictionary = document.ToDictionary();

            mensajeMostrar = mensajeMostrar +" Jugador: " +documentDictionary["Nombre del jugador"];
            mensajeMostrar = mensajeMostrar +" Con recursos totales: "+ documentDictionary["Recursos Totales"];
            mensajeMostrar = mensajeMostrar + "\n";
            
                //Debug.Log("Nombre del jugador: "+documentDictionary["Nombre del jugador"]);
                //Debug.Log("Recursos Totales: "+documentDictionary["Recursos Totales"]);
                //Debug.Log("");
            }
            mensaje = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MensajesManager>();
            mensaje.mostrarMensaje(mensajeMostrar);
        });
        

    }

    private void escribirJugadorRanking()
    {
        puntuacion = new Dictionary<string, object>
            {
                {"Recursos Totales",recursosTotales.text.ToString() },
                {"Nombre del jugador",nombreJugador.text.ToString() },
            };
        db = FirebaseFirestore.DefaultInstance;

        Guid myuuid = Guid.NewGuid();
        //Debug.Log(myuuid);

        db.Collection("Ranking").Document(myuuid.ToString()).SetAsync(puntuacion).ContinueWith(task => {
            if (task.IsCompleted)
            {
                Debug.Log("Ranking guardado");
                accesoFirebase = true;
                mostrarMensaje();
                //obtenerJugadoresRanking();
            }
            else
            {
                Debug.Log("Ranking no guardado");
            }
        });
        
    }

    public void ascender()
    {
        int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());

        //PlayerPrefs.SetInt("puntosAscension", puntosAscension);
        //Debug.Log("Se van a guardar: " + puntosAscension);

        //SceneManager.LoadScene("Scene 1");

        //int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
        //Debug.Log("Se han cargado: " + nuevosPuntosAscension);
        cantidadPuntosAscension.text = ""+0;
        recursosTotales.text = "" + 0;

        //Debug.Log("puntos de ascension obtenidos: " + puntosAscension);

        EdificiosManager.instanciaEdificiosManager.prestigio = EdificiosManager.instanciaEdificiosManager.prestigio + puntosAscension;

        //Debug.Log("El prestigio ahora es de: " + EdificiosManager.instanciaEdificiosManager.prestigio);

    }

    public void refrescarRecursosTotales(int recursosTotales)
    {
        //Text textoRecursosTotales = GameObject.Find("Numero de recursos Totales").GetComponent<Text>();

        //textoRecursosTotales.text = "" + recursosTotales;

        //GameObject prueba = GameObject.Find("Prueba").GetComponent<GameObject>();

        //ScriptPrueba.instanciaPrueba.recursosTotales = recursosTotales;

    }

    public void refrescarPuntosAscension(int puntosAscension)
    {
        //Text textoPuntosAscension = GameObject.Find("Numero de puntos de ascension").GetComponent<Text>();

        //textoPuntosAscension.text = "" + puntosAscension;
        EdificiosManager.instanciaEdificiosManager.numeroPuntosPrestigio.text = "" + puntosAscension;

        //GameObject prueba = GameObject.Find("Prueba").GetComponent<GameObject>();

        //ScriptPrueba.instanciaPrueba.puntosAscension = puntosAscension;

    }

}
