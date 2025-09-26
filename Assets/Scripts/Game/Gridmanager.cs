using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gridmanager : MonoBehaviour
{
    public List <GridLayoutGroup> grilla;
    private Button [] botones;
    public bool activar = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obtener_grllas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void obtener_grllas()
    {
        foreach (var grillas in grilla)
        {
            botones = grillas.GetComponentsInChildren<Button>();
            if (activar == true)
            {
                cambiarorden();
            }
        }
    }
    public void cambiarorden()
    {
        foreach (var boton in botones)
        {
            int escogido = Random.Range(0, botones.Length);
            //print(escogido);
            boton.transform.SetSiblingIndex(escogido);
        }
    }
}
