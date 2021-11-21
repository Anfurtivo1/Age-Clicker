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

    public int edificiosTier1;
    public int edificiosTier2;
    public int edificiosTier3;
    public int edificiosTier4;
    public int edificiosTier5;

    public int costeEdificiosTier1;
    //Añadir una lista de ID de mejoras donde si hay 5 mejoras por nivel, en el primer nivel del id 1 al 5, en el segundo del 6 al 10, etc

    public Juego(int recursosActuales, int recursosTotales, int nivelPrestigio, string nivelActual, 
                 int edificiosTier1, int edificiosTier2, int edificiosTier3, int edificiosTier4, int edificiosTier5, 
                 int costeEdificiosTier1)
    {
        this.recursosActuales = recursosActuales;
        this.recursosTotales = recursosTotales;
        this.nivelPrestigio = nivelPrestigio;
        this.nivelActual = nivelActual;

        this.edificiosTier1 = edificiosTier1;
        this.edificiosTier2 = edificiosTier2;
        this.edificiosTier3 = edificiosTier1;
        this.edificiosTier4 = edificiosTier4;
        this.edificiosTier5 = edificiosTier5;

        this.costeEdificiosTier1 = costeEdificiosTier1;

    }

    public Juego()
    {

    }

}
