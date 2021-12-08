using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MejorasManager : MonoBehaviour
{
    public Text recursosActuales;


    public void comprarMejoraTier1()
    {
        if (SceneManager.GetActiveScene().name == "Scene 1")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 100)
            {
                Debug.Log("Has comprado la mejora 1");
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_1").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 5;
                Debug.Log("El poder de los edificios 1 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 1");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 2")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 100)
            {
                Debug.Log("Has comprado la mejora 1");
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_2").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 6;
                Debug.Log("El poder de los edificios 1 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 1");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 100)
            {
                Debug.Log("Has comprado la mejora 1");
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_3").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 7;
                Debug.Log("El poder de los edificios 1 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 1");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 4")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 100)
            {
                Debug.Log("Has comprado la mejora 1");
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_4").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 8;
                Debug.Log("El poder de los edificios 1 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 1");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 100)
            {
                Debug.Log("Has comprado la mejora 1");
                Button boton = GameObject.FindGameObjectWithTag("Mejora1_5").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio1 = 9;
                Debug.Log("El poder de los edificios 1 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 1");
            }
        }

    }

    public void comprarMejoraTier2()
    {
        if (SceneManager.GetActiveScene().name == "Scene 1")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 200)
            {
                Debug.Log("Has comprado la mejora 2");
                Button boton = GameObject.FindGameObjectWithTag("Mejora2_1").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio3 = EdificiosManager.instanciaEdificiosManager.poderEdificio3* 5;
                Debug.Log("El poder de los edificios 3 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 2");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 2")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 200)
            {
                Debug.Log("Has comprado la mejora 2");
                Button boton = GameObject.FindGameObjectWithTag("Mejora2_2").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio3 = 18;
                Debug.Log("El poder de los edificios 3 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 2");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 200)
            {
                Debug.Log("Has comprado la mejora 2");
                Button boton = GameObject.FindGameObjectWithTag("Mejora2_3").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio3 = 21;
                Debug.Log("El poder de los edificios 3 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 2");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 4")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 200)
            {
                Debug.Log("Has comprado la mejora 2");
                Button boton = GameObject.FindGameObjectWithTag("Mejora2_4").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio3 = 24;
                Debug.Log("El poder de los edificios 3 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 2");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 200)
            {
                Debug.Log("Has comprado la mejora 2");
                Button boton = GameObject.FindGameObjectWithTag("Mejora2_5").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio3 = 27;
                Debug.Log("El poder de los edificios 3 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 2");
            }
        }

    }

    public void comprarMejoraTier3()
    {
        if (SceneManager.GetActiveScene().name == "Scene 1")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 300)
            {
                Debug.Log("Has comprado la mejora 3");
                Button boton = GameObject.FindGameObjectWithTag("Mejora3_1").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio5 = EdificiosManager.instanciaEdificiosManager.poderEdificio5 * 5;
                Debug.Log("El poder de los edificios 5 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 3");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 2")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 300)
            {
                Debug.Log("Has comprado la mejora 3");
                Button boton = GameObject.FindGameObjectWithTag("Mejora3_2").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio5 = 30;
                Debug.Log("El poder de los edificios 5 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 3");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 3")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 300)
            {
                Debug.Log("Has comprado la mejora 3");
                Button boton = GameObject.FindGameObjectWithTag("Mejora3_3").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio5 = 31;
                Debug.Log("El poder de los edificios 5 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 3");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 4")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 300)
            {
                Debug.Log("Has comprado la mejora 3");
                Button boton = GameObject.FindGameObjectWithTag("Mejora3_4").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio5 = 40;
                Debug.Log("El poder de los edificios 5 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 3");
            }
        }

        if (SceneManager.GetActiveScene().name == "Scene 5")
        {
            int recursoActual = int.Parse(recursosActuales.text.ToString());

            if (recursoActual >= 300)
            {
                Debug.Log("Has comprado la mejora 3");
                Button boton = GameObject.FindGameObjectWithTag("Mejora3_5").GetComponent<Button>();
                EdificiosManager.instanciaEdificiosManager.poderEdificio5 = 45;
                Debug.Log("El poder de los edificios 5 ahora es de " + EdificiosManager.instanciaEdificiosManager.poderEdificio1);
                boton.interactable = false;
            }
            else
            {
                Debug.Log("No has podido comprar la mejora 3");
            }
        }

    }

}
