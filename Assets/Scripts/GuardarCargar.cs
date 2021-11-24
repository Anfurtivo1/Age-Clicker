using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.UI;

public class GuardarCargar : MonoBehaviour
{
    private ContadorRecursos contadorRecursos;
    public static GuardarCargar instancia;
    [HideInInspector] public Juego partida;
    //public bool haCargado;
    private string rutaAGuardar;
    public Text textoRecurso;
    public Text textoRecursoTotal;
    public Text cantidadEdificiosTier1;
    public Text costeEdifTier1;
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
        partida.recursosActuales = 0;
        instancia.textoRecurso.text = "0";
        textoRecurso.text = "0";
    }

    public void guardarPartida()
    {
        rutaAGuardar = Application.persistentDataPath+"/" + partida.nombrePartida+".aock";//Como va a ser multiplataforma, usamos esto

        /*if (File.Exists(rutaAGuardar))
        {
            Si el archivo existe, preguntar si se quiere sobreescribir, en caso afirmativo, se sobreescribe
        }*/
        int cantidadRecursos = Int32.Parse(textoRecurso.text.ToString());
        partida.nivelActual = SceneManager.GetActiveScene().name;
        partida.nombrePartida = "partida1";
        partida.recursosActuales = cantidadRecursos;
        recursosTotales = int.Parse(textoRecursoTotal.text.ToString());
        partida.recursosTotales = recursosTotales;

        int edificiosTier1 = int.Parse(cantidadEdificiosTier1.text.ToString());

        int costeEdificiosTier1 = int.Parse(costeEdifTier1.text.ToString());

        partida.nivelPrestigio = 0;
        partida.edificiosTier1 = edificiosTier1;
        partida.edificiosTier2 = 0;
        partida.edificiosTier3 = 0;
        partida.edificiosTier4 = 0;
        partida.edificiosTier5 = 0;

        partida.costeEdificiosTier1 = costeEdificiosTier1;

        var serializador = new XmlSerializer(typeof(Juego));
        FileStream stream = new FileStream(rutaAGuardar, FileMode.Create);
        serializador.Serialize(stream, partida);
        stream.Close();
        Debug.Log("Guardado");

    }

    public void cargarPartida()
    {
        rutaAGuardar = Application.persistentDataPath + "/" + partida.nombrePartida + ".aock";
        Debug.Log(rutaAGuardar);
        if (File.Exists(rutaAGuardar))
        {
            var serializador = new XmlSerializer(typeof(Juego));
            FileStream stream = new FileStream(rutaAGuardar, FileMode.Open);
            partida = serializador.Deserialize(stream) as Juego;
            stream.Close();
            string nivel = partida.nivelActual;
            Debug.Log(nivel);

            //textoRecurso.text =""+ partida.recursosActuales;
            //recursosTotales = partida.recursosTotales;
            //textoRecursoTotal.text = recursosTotales.ToString();

            //cantidadEdificiosTier1.text =""+partida.edificiosTier1;

            //costeEdifTier1.text = "" + partida.costeEdificiosTier1;

            

            PlayerPrefs.SetInt("recursos actuales",partida.recursosActuales);
            PlayerPrefs.SetInt("recursos totales",partida.recursosTotales);

            PlayerPrefs.SetInt("cantidad edificios tier1",partida.edificiosTier1);

            PlayerPrefs.SetInt("coste edificios tier1",partida.costeEdificiosTier1);

            SceneManager.LoadScene(nivel);

            textoRecurso.text = ""+PlayerPrefs.GetInt("recursos actuales");
            recursosTotales = PlayerPrefs.GetInt("recursos totales");
            textoRecursoTotal.text = recursosTotales.ToString();

            cantidadEdificiosTier1.text =""+PlayerPrefs.GetInt("cantidad edificios tier1");

            costeEdifTier1.text = "" + PlayerPrefs.GetInt("coste edificios tier1");

            Debug.Log("Cargado");
        }
    }
}
