using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Juego 
{
    public string nombrePartida;
    public int recursosActuales;
    public int recursosTotales;
    public int nivelPrestigio;
    public string nivelActual;

    public Edificios edificios;

    public Mejoras mejoras;

    public int cantidadSiguienteNivelAscension;

    public int prestigio;

public Juego(int recursosActuales, int recursosTotales, int nivelPrestigio, string nivelActual,int cantidadSiguienteNivelAscension,int prestigio, Mejoras mejoras, Edificios edificios)
{
    this.recursosActuales = recursosActuales;
    this.recursosTotales = recursosTotales;
    this.nivelPrestigio = nivelPrestigio;
    this.nivelActual = nivelActual;

    this.cantidadSiguienteNivelAscension = cantidadSiguienteNivelAscension;

    this.prestigio = prestigio;
}

    public Juego()
    {

    }

}
