using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Mostrar_canvas : MonoBehaviour
{
    public GameObject Canvas_main_menu;
    public GameObject Canvas_Opciones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void mostrar_opciones()
    {
        Canvas_main_menu.SetActive(false);
        Canvas_Opciones.SetActive(true);
    }

    public void mostrar_menu()
    {
        Canvas_main_menu.SetActive(true);
        Canvas_Opciones.SetActive(false);
    }
    /*     class Guieditor : Editor
        {

        } */
}
