using UnityEngine;

public class pause_controller : MonoBehaviour
{
    public GameObject canvas_pausa;
    public GameObject juego;
    bool pausado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausado)
            {
                pausar();
            }
            else
            {
                reanudar();
            }
        }
    }

    public void reanudar()
    {
        canvas_pausa.SetActive(false);
        juego.SetActive(true);
        pausado = false;
    }
    public void pausar()
    {
        canvas_pausa.SetActive(true);
        juego.SetActive(false);
        pausado = true;
    }
}


 