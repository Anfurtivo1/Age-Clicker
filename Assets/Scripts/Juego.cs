using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Juego 
{
    public string idPartida;
    public string nombrePartida;
    public int recursosActuales;
    //Añadir una lista de ID de mejoras donde si hay 5 mejoras por nivel, en el primer nivel del id 1 al 5, en el segundo del 6 al 10, etc

    public Juego(int recursosActuales)
    {
        this.recursosActuales = recursosActuales;
    }

    public Juego()
    {

    }

}
