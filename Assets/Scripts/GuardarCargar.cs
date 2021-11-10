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
        
        partida.nivelPrestigio = 0;
        partida.edificiosTier1 = 0;
        partida.edificiosTier2 = 0;
        partida.edificiosTier3 = 0;
        partida.edificiosTier4 = 0;
        partida.edificiosTier5 = 0;

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
            SceneManager.LoadScene(nivel);
            recursosTotales = partida.recursosTotales;
            textoRecursoTotal.text = recursosTotales.ToString();
            Debug.Log("Cargado");
        }
    }
}
