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

        partida.nivelPrestigio = cantidadAscension;
        partida.cantidadSiguienteNivelAscension = cantidadSiguienteAscension;
        partida.edificiosTier1 = edificiosTier1;
        partida.edificiosTier2 = edificiosTier2;
        partida.edificiosTier3 = edificiosTier3;
        partida.edificiosTier4 = edificiosTier4;
        partida.edificiosTier5 = edificiosTier5;

        partida.costeEdificiosTier1 = costeEdificiosTier1;
        partida.costeEdificiosTier2 = costeEdificiosTier2;
        partida.costeEdificiosTier3 = costeEdificiosTier3;
        partida.costeEdificiosTier4 = costeEdificiosTier4;
        partida.costeEdificiosTier5 = costeEdificiosTier5;

        Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();

        if (!boton.interactable)
        {
            partida.mejora1_1_Activada = true;
        }

        //if (boton.interactable)
        //{
        //    partida.mejora2_1_Activada = true;
        //}

        //if (boton.interactable)
        //{
        //    partida.mejora3_1_Activada = true;
        //}

        //if (boton.interactable)
        //{
        //    partida.mejora1_2_Activada = true;
        //}

        //if (boton.interactable)
        //{
        //    partida.mejora2_2_Activada = true;
        //}

        //if (boton.interactable)
        //{
        //    partida.mejora3_2_Activada = true;
        //}



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
            //SceneManager.LoadScene(nivel);

            cantidadPuntosAscension.text = ""+partida.nivelPrestigio;
            EdificiosManager.instanciaEdificiosManager.cantidadSiguienteAscension = partida.cantidadSiguienteNivelAscension;

            textoRecurso.text =""+ partida.recursosActuales;
            recursosTotales = partida.recursosTotales;
            textoRecursoTotal.text = recursosTotales.ToString();

            cantidadEdificiosTier1.text =""+partida.edificiosTier1;

            costeEdifTier1.text = "" + partida.costeEdificiosTier1;

            cantidadEdificiosTier2.text = "" + partida.edificiosTier2;

            costeEdifTier2.text = "" + partida.costeEdificiosTier2;

            cantidadEdificiosTier3.text = "" + partida.edificiosTier3;

            costeEdifTier3.text = "" + partida.costeEdificiosTier3;

            cantidadEdificiosTier4.text = "" + partida.edificiosTier4;

            costeEdifTier4.text = "" + partida.costeEdificiosTier4;

            cantidadEdificiosTier5.text = "" + partida.edificiosTier5;

            costeEdifTier5.text = "" + partida.costeEdificiosTier5;

            if (partida.mejora1_1_Activada)
            {
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 5;
                boton.interactable = false;
            }

            if (partida.mejora2_1_Activada)
            {

            }

            if (partida.mejora3_1_Activada)
            {

            }

            //if (partida.mejora1_2_Activada)
            //{

            //}

            //if (partida.mejora2_2_Activada)
            //{

            //}

            //if (partida.mejora2_3_Activada)
            //{

            //}

            Debug.Log("Cargado");
        }
    }
}
