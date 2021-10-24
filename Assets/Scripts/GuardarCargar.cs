using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System;

public class GuardarCargar : MonoBehaviour
{
    public static GuardarCargar instancia;
    public Juego partida;
    public bool haCargado;
    private string rutaAGuardar;
    //private BinaryFormatter formateador;

    private void Awake()
    {
        instancia = this;
        cargarPartida();
    }

    private void Start()
    {
        if (true)
        {

        }
    }

    public void guardarPartida()
    {
        rutaAGuardar = Application.persistentDataPath+"/" + partida.nombrePartida+".aock";//Como va a ser multiplataforma, usamos esto
        var serializador = new XmlSerializer(typeof(Juego));
        FileStream stream = new FileStream(rutaAGuardar, FileMode.Create);
        serializador.Serialize(stream,partida);
        stream.Close();
        Debug.Log("Guardado");
    }

    public void cargarPartida()
    {
        rutaAGuardar = Application.persistentDataPath + "/" + partida.nombrePartida + ".aock";
        if (File.Exists(rutaAGuardar))
        {
            var serializador = new XmlSerializer(typeof(Juego));
            FileStream stream = new FileStream(rutaAGuardar, FileMode.Open);
            partida = serializador.Deserialize(stream) as Juego;
            stream.Close();
            haCargado = true;
            Debug.Log("Cargado");
        }
    }

    /*public void guardarPartida()
    {
        var json = JsonUtility.ToJson(partida);

        using (FileStream stream = new FileStream(rutaAGuardar, FileMode.Create))
        {
            formateador.Serialize(stream, json);
        }
    }

    public void cargarPartida()
    {
        if (!File.Exists(rutaAGuardar))
        {
            partida = new Juego();
            partida.recursosActuales = 50;
            guardarPartida();
        }
        using (FileStream stream = new FileStream(rutaAGuardar, FileMode.Open))
        {
            String InfoPartida = (string)formateador.Deserialize(stream);
            partida = JsonUtility.FromJson<Juego>(InfoPartida);
        }
    }*/

    /*public static bool guardar(string nombrePartida, Juego partidaAGuardar)
    {
        BinaryFormatter formateador = getFormateador();

        if (Directory.Exists(Application.persistentDataPath + "/partidas"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/partidas");
        }
        string rutaAGuardar = Application.persistentDataPath + "/partidas" + nombrePartida + ".save";

        FileStream partida = File.Create(rutaAGuardar);

        formateador.Serialize(partida, partidaAGuardar);

        partida.Close();

        return true;

    }

    public static object cargarPartida (string ruta)
    {
        if (!File.Exists(ruta))
        {
            return null;

        }

        BinaryFormatter formateador = getFormateador();
        FileStream partida = File.Open(ruta, FileMode.Open);

        try
        {
            object partidaACargar = formateador.Deserialize(partida);
            partida.Close();
            return partidaACargar;
        }
        catch (Exception)
        {
            Debug.LogError("No se ha podido cargar la partida en "+ruta);
            partida.Close();
            return null;
        }


    }


    public static BinaryFormatter getFormateador()
    {
        BinaryFormatter formateador = new BinaryFormatter();

        return formateador;
    }*/





    /*public static List<Juego> partidasGuardadas = new List<Juego>();

    public static void guardarPartida()
    {
        partidasGuardadas.Add(Juego.partidaActual);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/partidasGuardadas.gd");
        bf.Serialize(file, GuardarCargar.partidasGuardadas);
        file.Close();
    }

    public static void cargarPartidas()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            GuardarCargar.partidasGuardadas = (List<Juego>)bf.Deserialize(file);
            file.Close();
        }
    }*/
}
