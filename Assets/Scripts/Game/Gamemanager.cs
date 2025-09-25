using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Gamemanager : MonoBehaviour
{
    public enum dificultad { FACIL, NORMAL, DIFICL}

    public int intentos = 3;
    public dificultad ajuste_dificultad;
    public GameObject panel_gameplay_facil;
    public GameObject panel_gameplay_normal;
    public GameObject panel_gameplay_dificil;
    public UnityEvent GANASTE;
    public UnityEvent PERDISTE;
    carta[] cartas_en_game;
    int cantidad_cartas;
    int cartas_restante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        empezar_juego();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void empezar_juego()
    {
        if (ajuste_dificultad == dificultad.FACIL)
        {
            cartas_en_game = panel_gameplay_facil.GetComponentsInChildren<carta>();
            foreach (var carta in cartas_en_game)
            {
                cantidad_cartas++;
            }
            cartas_restante = cantidad_cartas;
        }
        else if (ajuste_dificultad == dificultad.NORMAL)
        {
            cartas_en_game = panel_gameplay_normal.GetComponentsInChildren<carta>();
            foreach (var carta in cartas_en_game)
            {
                cantidad_cartas++;
            }
            cartas_restante = cantidad_cartas;
        }
        else if (ajuste_dificultad == dificultad.DIFICL)
        {
            cartas_en_game = panel_gameplay_dificil.GetComponentsInChildren<carta>();
            foreach (var carta in cartas_en_game)
            {
                cantidad_cartas++;
            }
            cartas_restante = cantidad_cartas;
        }
    }



    public void Verificar_resultado()
    {
        if (cartas_restante == 0)
        {
            //GANASTE
            print("VICTORIAA");
            GANASTE.Invoke();
        }
        else if (intentos <= 0)
        {
            print("PERDISTEEE");
            desactivar_cartas();
            PERDISTE.Invoke();
        }
    }

    public void descontar()
    {
        cartas_restante -= 2;
        print("SE DESCONTO");
        Verificar_resultado();
    }

    public void descontar_intento()
    {
        intentos--;
        Verificar_resultado();
    }

    public void desactivar_cartas()
    {
        //DESACTIVAMOS TODA LAS CARTAS
        foreach (var carta in cartas_en_game)
        {
            carta.interactuable(false);
        }
    }
}
