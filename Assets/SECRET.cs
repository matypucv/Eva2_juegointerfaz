using UnityEngine;
using UnityEngine.UI;

public class SECRET : MonoBehaviour
{
    public int cantidad= 8;
    int clicks;
    public GameObject object_canvas_Secret;
    public AudioClip sfx_interactuado;
    public AudioClip sfx_desbloqueado;
    Button boton;
    Animator animator;
    bool bloqueado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        clicks = cantidad;
        boton = GetComponentInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void descontar()
    {

        //SI NO ESTA DESBLOQUEADO DEBERIA HACER LA ANIMACION Y DESCONTAR
        if (!bloqueado)
        {
            clicks--;
            if (clicks != 0 || clicks > 0)
            {
                animator.Play("INTERACTE");
                AudioManager.instance.PlaySFX(sfx_interactuado);
            }
            else if (clicks <= 0)
            {
                AudioManager.instance.PlaySFX(sfx_desbloqueado);
                bloqueado = true;
                animator.Play("INTERACTE");
                object_canvas_Secret.SetActive(true);
                //boton.interactable = false;
            }
        }
        // SI ESTA DESBLOQUEADO DEBERIA ACTIVAR EL GAMEOBJECT
        else
        {
        }
    }
}
