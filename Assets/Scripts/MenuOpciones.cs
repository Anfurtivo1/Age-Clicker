using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField]Vector2 spacing;
    Button botonPrincipal;
    MenuOpcionesItem[] items;
    bool expandido = false;
    Vector2 posicionBotonPrincipal;
    int cantidadBotones;

    // Start is called before the first frame update
    void Start()
    {
        cantidadBotones = transform.childCount - 1; //Porque el primer bot�n al ser el principal no cuenta
        items = new MenuOpcionesItem[cantidadBotones];
        for (int i = 0; i < cantidadBotones; i++)
        {
            items[i] = transform.GetChild(i + 1).GetComponent<MenuOpcionesItem>();
        }
        botonPrincipal = transform.GetChild(0).GetComponent<Button>();//Conseguimos el bot�n principal
        botonPrincipal.onClick.AddListener(cambiarEstadoMenu);
        botonPrincipal.transform.SetAsLastSibling();//hacemos que el bot�n principal siempre sea el que este mas arriba
        

        posicionBotonPrincipal = botonPrincipal.transform.position;
        
        resetearPosicion();

    }
    //Metodo para contraer el men�
    private void resetearPosicion()
    {
        for (int i = 0; i < cantidadBotones; i++)
        {
            items[i].trans.position = posicionBotonPrincipal;
        }
    }

    private void cambiarEstadoMenu()
    {

        expandido = !expandido;

        if (expandido)
        {
            for (int i = 0; i < cantidadBotones; i++)
            {
                items[i].trans.position = posicionBotonPrincipal + spacing * (i+1);
            }
        }
        else
        {
            for (int i = 0; i < cantidadBotones; i++)
            {
                items[i].trans.position = posicionBotonPrincipal;
            }
        }

    }

    private void OnDestroy()
    {
        botonPrincipal.onClick.RemoveListener(cambiarEstadoMenu);
    }
}
