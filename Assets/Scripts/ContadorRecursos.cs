using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorRecursos : MonoBehaviour
{
    public Text textoRecurso;
    public Text textoRecursoTotal;
    int suma;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GuardarCargar.instancia.partida.recursosActuales++;
        //    string recurso = GuardarCargar.instancia.partida.recursosActuales.ToString();
        //    textoRecurso.text = recurso;

        //    suma = int.Parse(textoRecursoTotal.text.ToString());
        //    suma++;
        //    recurso = GuardarCargar.instancia.recursosTotales.ToString();
            
        //    textoRecursoTotal.text = suma.ToString();
        //}
        
    }

    public void sumarPuntos()
    {
        GuardarCargar.instancia.partida.recursosActuales++;
        string recurso = GuardarCargar.instancia.partida.recursosActuales.ToString();
        textoRecurso.text = recurso;

        suma = int.Parse(textoRecursoTotal.text.ToString());
        suma++;
        recurso = GuardarCargar.instancia.recursosTotales.ToString();

        textoRecursoTotal.text = suma.ToString();
    }

}
