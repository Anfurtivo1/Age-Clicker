using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CasosDePrueba
{
    //Se comprueba que el archivo de guardado se ha guardado donde se debe de guardar
    [Test]
    public void ComprobacionArchivoGuardar()
    {
        string nombreJugador = "Juan";
        string nombrePartidaEsperado = Application.persistentDataPath+"\\"+nombreJugador+".aock";


        string[] partidas = Directory.GetFiles(Application.persistentDataPath,nombreJugador+".aock");

        Assert.AreEqual(nombrePartidaEsperado, partidas[0]);
    }

    [Test]
    public void ComprobacionArchivoCargarNivel()
    {
        Juego partidaEsperada = new Juego();
        Juego partidaRecuperada;
        string nombreJugador = "Juan";

        //partidaEsperada.nombrePartida = nombreJugador;
        partidaEsperada.nivelActual = "Scene 1";
        //partidaEsperada.nivelPrestigio = 1;

        string rutaAGuardar = Application.persistentDataPath + "/" + nombreJugador + ".aock";
        var serializador = new XmlSerializer(typeof(Juego));
        FileStream stream = new FileStream(rutaAGuardar, FileMode.Open);
        partidaRecuperada = serializador.Deserialize(stream) as Juego;
        stream.Close();

        Assert.AreEqual(partidaEsperada.nivelActual,partidaRecuperada.nivelActual);

    }

    [Test]
    public void ComprobacionArchivoCargarNivelPrestigio()
    {
        Juego partidaEsperada = new Juego();
        Juego partidaRecuperada;
        string nombreJugador = "Juan";

        partidaEsperada.prestigio = 1;

        string rutaAGuardar = Application.persistentDataPath + "/" + nombreJugador + ".aock";
        var serializador = new XmlSerializer(typeof(Juego));
        FileStream stream = new FileStream(rutaAGuardar, FileMode.Open);
        partidaRecuperada = serializador.Deserialize(stream) as Juego;
        stream.Close();

        Assert.AreEqual(partidaEsperada.prestigio, partidaRecuperada.prestigio);

    }

    //// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    //// `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator CasosDePruebaWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}
}
