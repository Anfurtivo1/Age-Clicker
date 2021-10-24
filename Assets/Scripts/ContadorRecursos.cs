using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorRecursos : MonoBehaviour
{
    public int recursoActual = 0;
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
            recursoActual++;
        }

        string recurso = recursoActual.ToString();
        textoRecurso.text = recurso;
    }
}
