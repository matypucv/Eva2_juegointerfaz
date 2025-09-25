using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using System.Collections.Generic;

public class Cambio_dificultad : MonoBehaviour
{
    public TMP_Dropdown opciones;
    public List<GameObject> paneles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //opciones.onValueChanged.AddListener(cambiar_dificultad);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void change_dificultad()
    {
        if (opciones.value == 0)
        {
            paneles[0].SetActive(true);
            paneles[1].SetActive(false);
            paneles[2].SetActive(false);
        }
        else if (opciones.value == 1)
        {
            paneles[0].SetActive(false);
            paneles[1].SetActive(true);
            paneles[2].SetActive(false);
        }
        else if (opciones.value == 2)
        {
            paneles[0].SetActive(false);
            paneles[1].SetActive(false);
            paneles[2].SetActive(true);
        }
    }
}
