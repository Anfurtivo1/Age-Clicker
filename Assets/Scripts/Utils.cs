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
    public GameObject panelNombre;
    public GameObject panelDatosHistoricos;
    public InputField input;
    public Button botonAceptar;
    static FirebaseFirestore db;
    Dictionary<string, object> puntuacion;
    Dictionary<string, object> datos;
    public String mensajeMostrar;
    private MensajesManager mensaje;
    private bool accesoFirebase = false;
    public GameObject panelRanking;
    public GameObject MensajeNoPasarNivel;
    public GameObject mensajeNoComprarMejora1;
    public GameObject mensajeNoComprarMejora2;
    public GameObject mensajeNoComprarMejora3;

    public void Start()
    {
        Button btn = botonAceptar.GetComponent<Button>();
        btn.onClick.AddListener(cambiarNombre);
        if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            mensaje = GameObject.FindGameObjectWithTag("GameManager").GetComponent<MensajesManager>();

        }
    }

    //public static void mostrarMensajeCargadoConExito()
    //{
    //    GameObject panelCargado = GameObject.FindGameObjectWithTag("Panel Cargado");
    //    panelCargado.SetActive(true);
    //}

    //public static void mostrarMensajeGuardadoConExito()
    //{
    //    GameObject panelGuardado = GameObject.FindGameObjectWithTag("Panel Guardado");
    //    panelGuardado.SetActive(true);
    //}

    //public static void cerrarMensajeCargadoConExito()
    //{

    //}

    //public static void cerrarMensajeGuardadoConExito()
    //{

    //}

    public void cambiarNombre()
    {
        nombreJugador.text = input.text;
        panelNombre.SetActive(false);
    }

    public void mostrarPanelDatosHistoricos()
    {
        panelDatosHistoricos.SetActive(true);
    }

    public void cerrarPanelDatosHistoricos()
    {
        panelDatosHistoricos.SetActive(false);
    }

    public void cerrarPanelRanking()
    {
        panelRanking.SetActive(false);
    }

    public void mostrarPanelCambiarNombre()
    {
        panelNombre.SetActive(true);
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

    public void MostrarMensajeNoPasarnivel()
    {
            MensajeNoPasarNivel.SetActive(true);
    }

    public void cerrarMensajeNoPasarNivel()
    {
        MensajeNoPasarNivel.SetActive(false);
    }



    public static void MostrarMensajeNoComprarMejora1()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();
        
        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora1")
        //    {
        //        panel = item;
        //        panel.SetActive(true);
        //    }
        //}
        
    }

    public static void MostrarMensajeNoComprarMejora2()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();

        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora2")
        //    {
        //        panel = item;
        //        panel.SetActive(true);
        //    }
        //}
    }

    public static void MostrarMensajeNoComprarMejora3()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();

        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora3")
        //    {
        //        panel = item;
        //        panel.SetActive(true);
        //    }
        //}
    }

    public static void cerrarMensajeNoComprarMejora1()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();

        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora1")
        //    {
        //        panel = item;
        //        panel.SetActive(false);
        //    }
        //}
    }

    public static void cerrarMensajeNoComprarMejora2()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();

        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora2")
        //    {
        //        panel = item;
        //        panel.SetActive(false);
        //    }
        //}
    }

    public void cerrarMensajeNoComprarMejora3()
    {
        //GameObject panel;
        //GameObject[] objetos = GameObject.FindGameObjectWithTag("GameManager").GetComponents<GameObject>();

        //foreach (var item in objetos)
        //{
        //    if (item.tag == "Panel Mejora3")
        //    {
        //        panel = item;
        //        panel.SetActive(false);
        //    }
        //}
    }

    public void pasarNivel()
    {
        int totales = int.Parse(recursosTotales.text.ToString());

        if (totales >= 3000 && SceneManager.GetActiveScene().name == "Scene 1")
        {

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
            MostrarMensajeNoPasarnivel();
            Debug.Log("No puedes acceder a ese nivel aún");
        }

        if (totales >= 5000 && SceneManager.GetActiveScene().name == "Scene 2")
        {

            int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());
            int recursoTotal = int.Parse(recursosTotales.text.ToString());

            PlayerPrefs.SetInt("puntosAscension", puntosAscension);
            PlayerPrefs.SetInt("recursosTotales", recursoTotal);

            //Debug.Log("Se van a guardar: " + puntosAscension+" puntos de ascension");
            //Debug.Log("Se van a guardar: " + recursoTotal+" recursos totales");

            SceneManager.LoadScene("Scene 3");

            int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
            int nuevosRecursosTotales = PlayerPrefs.GetInt("recursosTotales");

            //Debug.Log("Se han cargado: " + nuevosPuntosAscension +" puntos de ascension");
            //Debug.Log("Se han cargado: " + nuevosRecursosTotales + " recursos totales");

            //refrescarPuntosAscension(nuevosPuntosAscension);
            //refrescarRecursosTotales(nuevosRecursosTotales);
        }
        else
        {
            MostrarMensajeNoPasarnivel();
            Debug.Log("No puedes acceder a ese nivel aún");
        }

        if (totales >= 7000 && SceneManager.GetActiveScene().name == "Scene 3")
        {

            int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());
            int recursoTotal = int.Parse(recursosTotales.text.ToString());

            PlayerPrefs.SetInt("puntosAscension", puntosAscension);
            PlayerPrefs.SetInt("recursosTotales", recursoTotal);

            //Debug.Log("Se van a guardar: " + puntosAscension+" puntos de ascension");
            //Debug.Log("Se van a guardar: " + recursoTotal+" recursos totales");

            SceneManager.LoadScene("Scene 4");

            int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
            int nuevosRecursosTotales = PlayerPrefs.GetInt("recursosTotales");

            //Debug.Log("Se han cargado: " + nuevosPuntosAscension +" puntos de ascension");
            //Debug.Log("Se han cargado: " + nuevosRecursosTotales + " recursos totales");

            //refrescarPuntosAscension(nuevosPuntosAscension);
            //refrescarRecursosTotales(nuevosRecursosTotales);
        }
        else
        {
            MostrarMensajeNoPasarnivel();
            Debug.Log("No puedes acceder a ese nivel aún");
        }
        if (totales >= 9000 && SceneManager.GetActiveScene().name == "Scene 4")
        {

            escribirJugadorRanking();

            int puntosAscension = int.Parse(cantidadPuntosAscension.text.ToString());
            int recursoTotal = int.Parse(recursosTotales.text.ToString());

            PlayerPrefs.SetInt("puntosAscension", puntosAscension);
            PlayerPrefs.SetInt("recursosTotales", recursoTotal);

            //Debug.Log("Se van a guardar: " + puntosAscension+" puntos de ascension");
            //Debug.Log("Se van a guardar: " + recursoTotal+" recursos totales");

            SceneManager.LoadScene("Scene 5");

            int nuevosPuntosAscension = PlayerPrefs.GetInt("puntosAscension");
            int nuevosRecursosTotales = PlayerPrefs.GetInt("recursosTotales");

            //Debug.Log("Se han cargado: " + nuevosPuntosAscension +" puntos de ascension");
            //Debug.Log("Se han cargado: " + nuevosRecursosTotales + " recursos totales");

            //refrescarPuntosAscension(nuevosPuntosAscension);
            //refrescarRecursosTotales(nuevosRecursosTotales);
        }
        else
        {
            MostrarMensajeNoPasarnivel();
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

    public void obtenerPartidaJugadores()
    {
        Juego partida = new Juego();
        Edificios edificios = new Edificios();
        Mejoras mejoras = new Mejoras();
        db = FirebaseFirestore.DefaultInstance;
        db.Collection("Jugadores").GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            QuerySnapshot snapshot = task.Result;
            if (task.IsCompleted)
            {
                //QuerySnapshot snapshot = task.Result;
                foreach (DocumentSnapshot datos in snapshot.Documents)
                {
                    Dictionary<string, object> documentDictionary = datos.ToDictionary();

                    if (datos.Id == nombreJugador.text)
                        {
                            //partida.nombrePartida = document.Id;
                            partida.cantidadSiguienteNivelAscension = int.Parse("" + documentDictionary["cantidadSiguienteNivelAscension"]);
                            partida.nivelActual = "" + documentDictionary["nivelActual"];
                            partida.nivelPrestigio = int.Parse("" + documentDictionary["nivelPrestigio"]);
                            partida.prestigio = int.Parse("" + documentDictionary["prestigio"]);
                            partida.recursosActuales = int.Parse("" + documentDictionary["recursosActuales"]);
                            partida.recursosTotales = int.Parse("" + documentDictionary["recursosTotales"]);
                        

                            edificios.edificiosTier1 = int.Parse(""+documentDictionary["edificiosTier1"]);
                            edificios.edificiosTier2 = int.Parse("" + documentDictionary["edificiosTier2"]);
                            edificios.edificiosTier3 = int.Parse("" + documentDictionary["edificiosTier3"]);
                            edificios.edificiosTier4 = int.Parse("" + documentDictionary["edificiosTier4"]);
                            edificios.edificiosTier5 = int.Parse("" + documentDictionary["edificiosTier5"]);

                            edificios.costeEdificiosTier1 = int.Parse("" + documentDictionary["costeEdificiosTier1"]);
                            edificios.costeEdificiosTier2 = int.Parse("" + documentDictionary["costeEdificiosTier2"]);
                            edificios.costeEdificiosTier3 = int.Parse("" + documentDictionary["costeEdificiosTier3"]);
                            edificios.costeEdificiosTier4 = int.Parse("" + documentDictionary["costeEdificiosTier4"]);
                            edificios.costeEdificiosTier5 = int.Parse("" + documentDictionary["costeEdificiosTier5"]);

                            partida.edificios = edificios;

                            mejoras.mejora1_1_Activada = bool.Parse("" + documentDictionary["Mejora1_1"]);
                            mejoras.mejora2_1_Activada = bool.Parse("" + documentDictionary["Mejora2_1"]);
                            mejoras.mejora3_1_Activada = bool.Parse("" + documentDictionary["Mejora3_1"]);
                            mejoras.mejora1_2_Activada = bool.Parse("" + documentDictionary["Mejora1_2"]);
                            mejoras.mejora2_2_Activada = bool.Parse("" + documentDictionary["Mejora2_2"]);
                            mejoras.mejora3_2_Activada = bool.Parse("" + documentDictionary["Mejora3_2"]);
                            mejoras.mejora1_3_Activada = bool.Parse("" + documentDictionary["Mejora1_3"]);
                            mejoras.mejora2_3_Activada = bool.Parse("" + documentDictionary["Mejora2_3"]);
                            mejoras.mejora3_3_Activada = bool.Parse("" + documentDictionary["Mejora3_3"]);
                            mejoras.mejora1_4_Activada = bool.Parse("" + documentDictionary["Mejora1_4"]);
                            mejoras.mejora2_4_Activada = bool.Parse("" + documentDictionary["Mejora2_4"]);
                            mejoras.mejora3_4_Activada = bool.Parse("" + documentDictionary["Mejora3_4"]);
                            mejoras.mejora1_5_Activada = bool.Parse("" + documentDictionary["Mejora1_5"]);
                            mejoras.mejora2_5_Activada = bool.Parse("" + documentDictionary["Mejora2_5"]);
                            mejoras.mejora3_5_Activada = bool.Parse("" + documentDictionary["Mejora3_5"]);

                            partida.mejoras = mejoras;

                            GuardarCargar.instancia.cargarPartida(partida);

                        }
                }
            }
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

        SceneManager.LoadScene("Scene 1");

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
