using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EdificiosManager : MonoBehaviour
{
    public Text recursosActuales;
    public Text recursoTotales;
    public Text contadorEdificios1;
    public Text contadorEdificios2;
    public Text contadorEdificios3;
    public Text contadorEdificios4;
    public Text contadorEdificios5;
    public int costeEdificio1 = 10;

    int prestigio = 1;
    int edificios1;
    int edificios2;
    int edificios3;
    int edificios4;
    int edificios5;

    public void Update()
    {
        StartCoroutine(sumarRecursosEdificios());
        
    }

    IEnumerator sumarRecursosEdificios()
    {
        yield return new WaitForSecondsRealtime(8);

        edificios1 = int.Parse(contadorEdificios1.text.ToString());
        edificios2 = int.Parse(contadorEdificios2.text.ToString());
        edificios3 = int.Parse(contadorEdificios3.text.ToString());
        edificios4 = int.Parse(contadorEdificios4.text.ToString());
        edificios5 = int.Parse(contadorEdificios5.text.ToString());

        edificios1 = edificios1 * prestigio * 1;
        edificios2 = edificios2 * prestigio * 2;
        edificios3 = edificios3 * prestigio * 3;
        edificios4 = edificios4 * prestigio * 4;
        edificios5 = edificios5 * prestigio * 5;

        int sumaTotal = (edificios1 + edificios2 + edificios3 + edificios4 + edificios5);




        int recursoActual = int.Parse(recursosActuales.text.ToString());
        recursoActual = sumaTotal + recursoActual;

        recursosActuales.text = "" + recursoActual;
        GuardarCargar.instancia.partida.recursosActuales = GuardarCargar.instancia.partida.recursosActuales + sumaTotal;




        int recursoTotal = int.Parse(recursoTotales.text.ToString());
        recursoTotal = sumaTotal+recursoTotal;

        recursoTotales.text = ""+recursoTotal;
    }

    public void comprarEdificio1_1()
    {
        int recursos = int.Parse(recursosActuales.text.ToString());
        if (recursos>= costeEdificio1)
        {
            recursos = recursos - costeEdificio1;
            recursosActuales.text = ""+recursos;
            GuardarCargar.instancia.partida.recursosActuales = recursos;

            int cantidadEdificiosActuales = int.Parse(contadorEdificios1.text);
            cantidadEdificiosActuales++;
            contadorEdificios1.text = ""+cantidadEdificiosActuales;
            Debug.Log("Has comprado un edificio");
            costeEdificio1 = costeEdificio1 * 5;
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
