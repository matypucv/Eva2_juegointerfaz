using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Gamemanager : MonoBehaviour
{
    public enum dificultad { FACIL, NORMAL, DIFICL}

    public dificultad ajuste_dificultad;
    public List<carta> Cartas;
    public GameObject panel_gameplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void empezar_juego()
    {
        if (ajuste_dificultad == dificultad.FACIL)
        {

        }
        else if (ajuste_dificultad == dificultad.NORMAL)
        {

        }
        else if (ajuste_dificultad == dificultad.DIFICL)
        {

        }
    }
}
