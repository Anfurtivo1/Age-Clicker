using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorRecursos : MonoBehaviour
{
    public Text textoRecurso;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GuardarCargar.instancia.partida.recursosActuales++;
        }
        string recurso = GuardarCargar.instancia.partida.recursosActuales.ToString();
        textoRecurso.text = recurso;
    }
}
