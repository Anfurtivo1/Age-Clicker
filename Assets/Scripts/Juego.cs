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

    public bool mejora1_1_Activada;
    public bool mejora2_1_Activada;
    public bool mejora3_1_Activada;

    public int cantidadSiguienteNivelAscension;

    //Añadir campos de si esta activado o no, con true o false (mejora1_1 activada true), si esta activada, al cargar la partida
    //Se cambia el valor del poder del edificio

    public Juego(int recursosActuales, int recursosTotales, int nivelPrestigio, string nivelActual, 
                 int edificiosTier1, int edificiosTier2, int edificiosTier3, int edificiosTier4, int edificiosTier5, 
                 int costeEdificiosTier1,
                 bool mejora1_1_Activada, bool mejora2_1_Activada, bool mejora3_1_Activada,
                 int cantidadSiguienteNivelAscension)
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

        this.mejora1_1_Activada = mejora1_1_Activada;
        this.mejora2_1_Activada = mejora2_1_Activada;
        this.mejora3_1_Activada = mejora3_1_Activada;

        this.cantidadSiguienteNivelAscension = cantidadSiguienteNivelAscension;

    }

    public Juego()
    {

    }

}
