using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.UI;
using Firebase.Firestore;

public class GuardarCargar : MonoBehaviour
{
    static FirebaseFirestore db;
    [HideInInspector] public int prestigio = 1;
    //private ContadorRecursos contadorRecursos;
    public static GuardarCargar instancia;
    [HideInInspector] public Juego partida;
    //public bool haCargado;
    private string rutaAGuardar;
    public Text cantidadPuntosAscension;
    public int cantidadSiguienteAscension;
    public Text textoRecurso;
    public Text textoRecursoTotal;
    public Text cantidadEdificiosTier1;
    public Text costeEdifTier1;
    public Text cantidadEdificiosTier2;
    public Text costeEdifTier2;
    public Text cantidadEdificiosTier3;
    public Text costeEdifTier3;
    public Text cantidadEdificiosTier4;
    public Text costeEdifTier4;
    public Text cantidadEdificiosTier5;
    public Text costeEdifTier5;
    public Text nombreJugador;
    [HideInInspector] public int recursosTotales;
    [HideInInspector] public int recursosTotalesPartidaAnterior;
    //private BinaryFormatter formateador;

    private void Awake()
    {

        instancia = this;
        //cargarPartida();
    }

    private void Start()
    {
        /*partida.recursosActuales = 0;
        instancia.textoRecurso.text = "0";
        textoRecurso.text = "0";*/
    }

    public void guardarPartida()
    {
        //partida.nombrePartida = nombreJugador.text;
        //rutaAGuardar = Application.persistentDataPath+"/" + partida.nombrePartida+".aock";//Como va a ser multiplataforma, usamos esto

        int cantidadRecursos = Int32.Parse(textoRecurso.text.ToString());
        //partida.nivelActual = SceneManager.GetActiveScene().name;
        //partida.nombrePartida = nombreJugador.text;
        //partida.recursosActuales = cantidadRecursos;
        recursosTotales = int.Parse(textoRecursoTotal.text.ToString());
        //partida.recursosTotales = recursosTotales;

        int cantidadAscension = int.Parse(cantidadPuntosAscension.text.ToString());

        cantidadSiguienteAscension = EdificiosManager.instanciaEdificiosManager.cantidadSiguienteAscension;

        int edificiosTier1 = int.Parse(cantidadEdificiosTier1.text.ToString());

        int costeEdificiosTier1 = int.Parse(costeEdifTier1.text.ToString());

        int edificiosTier2 = int.Parse(cantidadEdificiosTier2.text.ToString());

        int costeEdificiosTier2 = int.Parse(costeEdifTier2.text.ToString());

        int edificiosTier3 = int.Parse(cantidadEdificiosTier3.text.ToString());

        int costeEdificiosTier3 = int.Parse(costeEdifTier3.text.ToString());

        int edificiosTier4 = int.Parse(cantidadEdificiosTier4.text.ToString());

        int costeEdificiosTier4 = int.Parse(costeEdifTier4.text.ToString());

        int edificiosTier5 = int.Parse(cantidadEdificiosTier5.text.ToString());

        int costeEdificiosTier5 = int.Parse(costeEdifTier5.text.ToString());

        Edificios edificio = new Edificios(edificiosTier1, edificiosTier2, edificiosTier3, edificiosTier4, edificiosTier5, 
            costeEdificiosTier1, costeEdificiosTier2, costeEdificiosTier3, costeEdificiosTier4, costeEdificiosTier5);

        Mejoras mejora = new Mejoras();

        if (SceneManager.GetActiveScene().name == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora1_1_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora2_1").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora2_1_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora3_1").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora3_1_Activada = true;
            }
        }



        if (SceneManager.GetActiveScene().name == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_2").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora1_2_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora2_2").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora2_2_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora3_2").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora3_2_Activada = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_3").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora1_3_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora2_3").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora2_3_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora3_3").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora3_3_Activada = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_4").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora1_4_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora2_4").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora2_4_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora3_4").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora3_4_Activada = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_5").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora1_5_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora2_5").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora2_5_Activada = true;
            }

            boton = GameObject.FindGameObjectWithTag("Mejora3_5").GetComponent<Button>();

            if (!boton.interactable)
            {
                mejora.mejora3_5_Activada = true;
            }
        }

        //partida.edificios = edificio;

        //partida.nivelPrestigio = cantidadAscension;
        //partida.cantidadSiguienteNivelAscension = cantidadSiguienteAscension;

        Dictionary<string, object> datos = new Dictionary<string, object>
            {
                {"cantidadSiguienteNivelAscension",cantidadSiguienteAscension.ToString() },
                {"nivelActual",SceneManager.GetActiveScene().name},
                {"nivelPrestigio",cantidadAscension.ToString() },
                {"prestigio",EdificiosManager.instanciaEdificiosManager.prestigio.ToString() },
                {"recursosActuales",cantidadRecursos.ToString() },
                {"recursosTotales",recursosTotales.ToString() },
                {"edificiosTier1",edificiosTier1.ToString() },
                {"edificiosTier2",edificiosTier2.ToString() },
                {"edificiosTier3",edificiosTier3.ToString() },
                {"edificiosTier4",edificiosTier4.ToString() },
                {"edificiosTier5",edificiosTier5.ToString() },
                {"costeEdificiosTier1",costeEdificiosTier1.ToString() },
                {"costeEdificiosTier2",costeEdificiosTier2.ToString() },
                {"costeEdificiosTier3",costeEdificiosTier3.ToString() },
                {"costeEdificiosTier4",costeEdificiosTier4.ToString() },
                {"costeEdificiosTier5",costeEdificiosTier5.ToString() },
                {"Mejora1_1",mejora.mejora1_1_Activada },
                {"Mejora2_1",mejora.mejora2_1_Activada },
                {"Mejora3_1",mejora.mejora3_1_Activada },
                {"Mejora1_2",mejora.mejora1_2_Activada },
                {"Mejora2_2",mejora.mejora2_2_Activada },
                {"Mejora3_2",mejora.mejora3_2_Activada },
                {"Mejora1_3",mejora.mejora1_3_Activada },
                {"Mejora2_3",mejora.mejora2_3_Activada },
                {"Mejora3_3",mejora.mejora3_3_Activada },
                {"Mejora1_4",mejora.mejora1_4_Activada },
                {"Mejora2_4",mejora.mejora2_4_Activada },
                {"Mejora3_4",mejora.mejora3_4_Activada },
                {"Mejora1_5",mejora.mejora1_5_Activada },
                {"Mejora2_5",mejora.mejora2_5_Activada },
                {"Mejora3_5",mejora.mejora3_5_Activada }
            };
        db = FirebaseFirestore.DefaultInstance;
        db.Collection("Jugadores").Document(nombreJugador.text).SetAsync(datos).ContinueWith(task => {
            if (task.IsCompleted)
            {
                Debug.Log("Partida guardada");
            }
            else
            {
                Debug.Log("Partida no guardada");
            }
        });

        //partida.prestigio = prestigio;

        //partida.mejoras = mejora;
        //var serializador = new XmlSerializer(typeof(Juego));
        //FileStream stream = new FileStream(rutaAGuardar, FileMode.Create);
        //serializador.Serialize(stream, partida);
        //stream.Close();
        //Utils.mostrarMensajeGuardadoConExito();
        //Debug.Log("Guardado");

    }

    public void cargarPartida(Juego partida)
    {
            partida.nombrePartida = nombreJugador.text;
            // rutaAGuardar = Application.persistentDataPath + "/" + partida.nombrePartida + ".aock";
            ////string[] partidas = Directory.GetFiles(Application.persistentDataPath,"*.aock");

            //// foreach (var item in partidas)
            //// {
            ////     Debug.Log(item);
            //// }

            //if (partida!=null)
            //{
            //var serializador = new XmlSerializer(typeof(Juego));
            //FileStream stream = new FileStream(rutaAGuardar, FileMode.Open);
            //partida = serializador.Deserialize(stream) as Juego;
            //stream.Close();
            //string nivel = partida.nivelActual;
            //Debug.Log(nivel);
            //SceneManager.LoadScene(nivel);

            //nombreJugador.text = partida.nombrePartida;

            cantidadPuntosAscension.text = ""+partida.nivelPrestigio;
            EdificiosManager.instanciaEdificiosManager.cantidadSiguienteAscension = partida.cantidadSiguienteNivelAscension;

            textoRecurso.text =""+ partida.recursosActuales;
            recursosTotales = partida.recursosTotales;
            textoRecursoTotal.text = recursosTotales.ToString();

            cantidadEdificiosTier1.text = "" + partida.edificios.edificiosTier1;

            costeEdifTier1.text = "" + partida.edificios.costeEdificiosTier1;

            cantidadEdificiosTier2.text = "" + partida.edificios.edificiosTier2;

            costeEdifTier2.text = "" + partida.edificios.costeEdificiosTier2;

            cantidadEdificiosTier3.text = "" + partida.edificios.edificiosTier3;

            costeEdifTier3.text = "" + partida.edificios.costeEdificiosTier3;

            cantidadEdificiosTier4.text = "" + partida.edificios.edificiosTier4;

            costeEdifTier4.text = "" + partida.edificios.costeEdificiosTier4;

            cantidadEdificiosTier5.text = "" + partida.edificios.edificiosTier5;

            costeEdifTier5.text = "" + partida.edificios.costeEdificiosTier5;

        if (partida.mejoras.mejora1_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 5;
            boton.interactable = false;
        }else if (!partida.mejoras.mejora1_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora2_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_1").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 15;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora2_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_1").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora3_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_1").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 25;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora3_1_Activada && partida.nivelActual == "Scene 1")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_1").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora1_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_2").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 6;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora1_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_2").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora2_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_2").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 18;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora2_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_2").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora3_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_2").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 30;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora3_2_Activada && partida.nivelActual == "Scene 2")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_2").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora1_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_3").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 7;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora1_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_3").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora2_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_3").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 21;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora2_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_3").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora3_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_3").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 35;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora3_3_Activada && partida.nivelActual == "Scene 3")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_3").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora1_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_4").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 8;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora1_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_4").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora2_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_4").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 24;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora2_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_4").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora3_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_4").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 40;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora3_4_Activada && partida.nivelActual == "Scene 4")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_4").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora1_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_5").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 9;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora1_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora1_5").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora2_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_5").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 27;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora2_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora2_5").GetComponent<Button>();
            boton.interactable = true;
        }

        if (partida.mejoras.mejora3_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_5").GetComponent<Button>();
            EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 45;
            boton.interactable = false;
        }
        else if (!partida.mejoras.mejora3_5_Activada && partida.nivelActual == "Scene 5")
        {
            Button boton = GameObject.FindGameObjectWithTag("Mejora3_5").GetComponent<Button>();
            boton.interactable = true;
        }

        //prestigio = partida.prestigio;
        //EdificiosManager.instanciaEdificiosManager.prestigio = partida.prestigio;

        //Utils.mostrarMensajeCargadoConExito();
        //Debug.Log("Cargado");
        //}
    }
}
