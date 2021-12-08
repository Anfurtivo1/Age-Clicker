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
    public int costeEdificiosTier2;
    public int costeEdificiosTier3;
    public int costeEdificiosTier4;
    public int costeEdificiosTier5;

    public bool mejora1_1_Activada;
    public bool mejora2_1_Activada;
    public bool mejora3_1_Activada;

    public bool mejora1_2_Activada;
    public bool mejora2_2_Activada;
    public bool mejora3_2_Activada;

    public bool mejora1_3_Activada;
    public bool mejora2_3_Activada;
    public bool mejora3_3_Activada;

    public bool mejora1_4_Activada;
    public bool mejora2_4_Activada;
    public bool mejora3_4_Activada;

    public bool mejora1_5_Activada;
    public bool mejora2_5_Activada;
    public bool mejora3_5_Activada;


    public int cantidadSiguienteNivelAscension;

    public int prestigio;

public Juego(int recursosActuales, int recursosTotales, int nivelPrestigio, string nivelActual, 
                int edificiosTier1, int edificiosTier2, int edificiosTier3, int edificiosTier4, int edificiosTier5, 
                int costeEdificiosTier1, int costeEdificiosTier2, int costeEdificiosTier3, int costeEdificiosTier4, int costeEdificiosTier5,
                bool mejora1_1_Activada, bool mejora2_1_Activada, bool mejora3_1_Activada, bool mejora1_2_Activada, bool mejora2_2_Activada, bool mejora3_2_Activada,
                bool mejora1_3_Activada, bool mejora2_3_Activada, bool mejora3_3_Activada, bool mejora1_4_Activada, bool mejora2_4_Activada, bool mejora3_4_Activada,
                bool mejora1_5_Activada, bool mejora2_5_Activada, bool mejora3_5_Activada,
                int cantidadSiguienteNivelAscension,int prestigio)
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
    this.costeEdificiosTier1 = costeEdificiosTier2;
    this.costeEdificiosTier1 = costeEdificiosTier3;
    this.costeEdificiosTier1 = costeEdificiosTier4;
    this.costeEdificiosTier1 = costeEdificiosTier5;

    this.mejora1_1_Activada = mejora1_1_Activada;
    this.mejora2_1_Activada = mejora2_1_Activada;
    this.mejora3_1_Activada = mejora3_1_Activada;

    this.mejora1_2_Activada = mejora1_2_Activada;
    this.mejora2_2_Activada = mejora2_2_Activada;
    this.mejora3_2_Activada = mejora3_2_Activada;

    this.mejora1_3_Activada = mejora1_3_Activada;
    this.mejora2_3_Activada = mejora2_3_Activada;
    this.mejora3_3_Activada = mejora3_3_Activada;

    this.mejora1_4_Activada = mejora1_4_Activada;
    this.mejora2_4_Activada = mejora2_4_Activada;
    this.mejora3_4_Activada = mejora3_4_Activada;

    this.mejora1_5_Activada = mejora1_5_Activada;
    this.mejora2_5_Activada = mejora2_5_Activada;
    this.mejora3_5_Activada = mejora3_5_Activada;

    this.cantidadSiguienteNivelAscension = cantidadSiguienteNivelAscension;

    this.prestigio = prestigio;
}

    public Juego()
    {

    }

}
