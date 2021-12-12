using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class CasosDePrueba
{

    [UnityTest]
    public IEnumerator comprobacionComprarEdificiosAumentoCantidad()
    {
        int cantidadEsperada = 1;
        int cantidadSacado;
        EditorSceneManager.LoadScene("Scene 1");

        yield return new WaitForSecondsRealtime(10);

        cantidadSacado = int.Parse(GuardarCargar.instancia.cantidadEdificiosTier1.text);

        Assert.AreEqual(cantidadEsperada,cantidadSacado);

    }

    [UnityTest]
    public IEnumerator comprobacionComprarEdificiosAumentoPrecio()
    {
        int cantidadEsperada = 20;
        int cantidadSacado;
        EditorSceneManager.LoadScene("Scene 1");

        yield return new WaitForSecondsRealtime(10);

        cantidadSacado = int.Parse(GuardarCargar.instancia.costeEdifTier1.text);

        Assert.AreEqual(cantidadEsperada, cantidadSacado);

    }

}