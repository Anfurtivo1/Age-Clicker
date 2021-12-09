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

    //public int edificiosTier1;
    //public int edificiosTier2;
    //public int edificiosTier3;
    //public int edificiosTier4;
    //public int edificiosTier5;

    //public int costeEdificiosTier1;
    //public int costeEdificiosTier2;
    //public int costeEdificiosTier3;
    //public int costeEdificiosTier4;
    //public int costeEdificiosTier5;

    public Mejoras mejoras;

    //public bool mejora1_1_Activada;
    //public bool mejora2_1_Activada;
    //public bool mejora3_1_Activada;

    //public bool mejora1_2_Activada;
    //public bool mejora2_2_Activada;
    //public bool mejora3_2_Activada;

    //public bool mejora1_3_Activada;
    //public bool mejora2_3_Activada;
    //public bool mejora3_3_Activada;

    //public bool mejora1_4_Activada;
    //public bool mejora2_4_Activada;
    //public bool mejora3_4_Activada;

    //public bool mejora1_5_Activada;
    //public bool mejora2_5_Activada;
    //public bool mejora3_5_Activada;


    public int cantidadSiguienteNivelAscension;

    public int prestigio;

public Juego(int recursosActuales, int recursosTotales, int nivelPrestigio, string nivelActual,int cantidadSiguienteNivelAscension,int prestigio, Mejoras mejoras, Edificios edificios)
{
    this.recursosActuales = recursosActuales;
    this.recursosTotales = recursosTotales;
    this.nivelPrestigio = nivelPrestigio;
    this.nivelActual = nivelActual;

    //this.edificios.edificiosTier1 = edificios.edificiosTier1;
    //this.edificios.edificiosTier2 = edificios.edificiosTier2;
    //this.edificios.edificiosTier3 = edificios.edificiosTier1;
    //this.edificios.edificiosTier4 = edificios.edificiosTier4;
    //this.edificios.edificiosTier5 = edificios.edificiosTier5;

    //this.edificios.costeEdificiosTier1 = edificios.costeEdificiosTier1;
    //this.edificios.costeEdificiosTier1 = edificios.costeEdificiosTier2;
    //this.edificios.costeEdificiosTier1 = edificios.costeEdificiosTier3;
    //this.edificios.costeEdificiosTier1 = edificios.costeEdificiosTier4;
    //this.edificios.costeEdificiosTier1 = edificios.costeEdificiosTier5;

    //this.mejoras.mejora1_1_Activada = mejoras.mejora1_1_Activada;
    //this.mejoras.mejora2_1_Activada = mejoras.mejora2_1_Activada;
    //this.mejoras.mejora3_1_Activada = mejoras.mejora3_1_Activada;

    //this.mejoras.mejora1_2_Activada = mejoras.mejora1_2_Activada;
    //this.mejoras.mejora2_2_Activada = mejoras.mejora2_2_Activada;
    //this.mejoras.mejora3_2_Activada = mejoras.mejora3_2_Activada;

    //this.mejoras.mejora1_3_Activada = mejoras.mejora1_3_Activada;
    //this.mejoras.mejora2_3_Activada = mejoras.mejora2_3_Activada;
    //this.mejoras.mejora3_3_Activada = mejoras.mejora3_3_Activada;

    //this.mejoras.mejora1_4_Activada = mejoras.mejora1_4_Activada;
    //this.mejoras.mejora2_4_Activada = mejoras.mejora2_4_Activada;
    //this.mejoras.mejora3_4_Activada = mejoras.mejora3_4_Activada;

    //this.mejoras.mejora1_5_Activada = mejoras.mejora1_5_Activada;
    //this.mejoras.mejora2_5_Activada = mejoras.mejora2_5_Activada;
    //this.mejoras.mejora3_5_Activada = mejoras.mejora3_5_Activada;

    this.cantidadSiguienteNivelAscension = cantidadSiguienteNivelAscension;

    this.prestigio = prestigio;
}

    public Juego()
    {

    }

}
