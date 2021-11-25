using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EdificiosManager : MonoBehaviour
{
   [HideInInspector] public static EdificiosManager instanciaEdificiosManager;

    public Text recursosActuales;
    public Text recursoTotales;
    public Text numeroPuntosPrestigio;

    public Text contadorEdificios1;
    public Text contadorEdificios2;
    public Text contadorEdificios3;
    public Text contadorEdificios4;
    public Text contadorEdificios5;
    public Text costeEdificios1;

   public int poderEdificio1 = 1;
   [HideInInspector] public int poderEdificio2 = 2;
   [HideInInspector] public int poderEdificio3 = 3;
   [HideInInspector] public int poderEdificio4 = 4;
   [HideInInspector] public int poderEdificio5 = 5;

    public int cantidadSiguienteAscension = 1000;
    private int puntosIniciales = 1000;

    //public int costeEdificio1 = 10;

    [HideInInspector] public int prestigio = 1;
    int edificios1;
    int edificios2;
    int edificios3;
    int edificios4;
    int edificios5;

    private void Awake()
    {
        instanciaEdificiosManager = this;
    }

    public void Update()
    {
        sumarRecursosEdificios();
        
    }

    private void sumarRecursosEdificios()
    {

        edificios1 = int.Parse(contadorEdificios1.text.ToString());
        edificios2 = int.Parse(contadorEdificios2.text.ToString());
        edificios3 = int.Parse(contadorEdificios3.text.ToString());
        edificios4 = int.Parse(contadorEdificios4.text.ToString());
        edificios5 = int.Parse(contadorEdificios5.text.ToString());

        if (edificios1>0 || edificios2 > 0 || edificios3 > 0 || edificios4 > 0 || edificios5 > 0)
        {

            edificios1 = edificios1 * prestigio * poderEdificio1;
            edificios2 = edificios2 * prestigio * poderEdificio2;
            edificios3 = edificios3 * prestigio * poderEdificio3;
            edificios4 = edificios4 * prestigio * poderEdificio4;
            edificios5 = edificios5 * prestigio * poderEdificio5;

            int sumaTotal = (edificios1 + edificios2 + edificios3 + edificios4 + edificios5);




            int recursoActual = int.Parse(recursosActuales.text.ToString());
            recursoActual = sumaTotal + recursoActual;

            recursosActuales.text = "" + recursoActual;
            GuardarCargar.instancia.partida.recursosActuales = GuardarCargar.instancia.partida.recursosActuales + sumaTotal;




            int recursoTotal = int.Parse(recursoTotales.text.ToString());
            recursoTotal = sumaTotal + recursoTotal;

            recursoTotales.text = "" + recursoTotal;


            cantidadSiguienteAscension = cantidadSiguienteAscension - recursoTotal;

            if (cantidadSiguienteAscension <= 0)
            {
                puntosIniciales = puntosIniciales +1000;
                cantidadSiguienteAscension = puntosIniciales;
                int puntos = int.Parse(numeroPuntosPrestigio.text.ToString());
                puntos++;
                numeroPuntosPrestigio.text = "" + puntos;
            }
        }


    }

    public void comprarEdificio1_1()
    {
        int recursos = int.Parse(recursosActuales.text.ToString());
        int costeEdificio1 = int.Parse(costeEdificios1.text.ToString());
        if (recursos>= costeEdificio1)
        {
            recursos = recursos - costeEdificio1;
            recursosActuales.text = ""+recursos;
            GuardarCargar.instancia.partida.recursosActuales = recursos;

            int cantidadEdificiosActuales = int.Parse(contadorEdificios1.text);
            cantidadEdificiosActuales++;
            contadorEdificios1.text = ""+cantidadEdificiosActuales;
            Debug.Log("Has comprado un edificio");
            costeEdificio1 = costeEdificio1 * 2;
            costeEdificios1.text = ""+costeEdificio1;
            Debug.Log("Edificio ahora cuesta "+ costeEdificio1);
        }
        else
        {
            Debug.Log("No puedes comprar el edificio");
        }
    }

    public void comprarEdificio2_1()
    {

    }


    public void comprarEdificio3_1()
    {

    }


    public void comprarEdificio4_1()
    {

    }


    public void comprarEdificio5_1()
    {

    }

}
