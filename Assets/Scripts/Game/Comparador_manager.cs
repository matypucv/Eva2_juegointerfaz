using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Comparador_manager : MonoBehaviour
{
    public AudioClip sfx_correct;
    public AudioClip sfx_error;
    public carta carta_A;
    public carta carta_B;
    public UnityEvent ACERTO;
    public UnityEvent FALLO;
    public List <carta> carta_al_comparador;
    [SerializeField] private Gamemanager gamemanager;
    int limite = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    public void comparar_cartas()
    {
        //verificar_estado();
        //SI AMBAS CARTAS TIENEN ALGO, RECIEN SE PODRAN COMPARRAR
        if (carta_A != null && carta_B != null)
        {
            //esperar();
            //SI AMBAS CARTAS TIENE EL MISMO ID ACIERTA
            if (carta_A.id_card == carta_B.id_card)
            {

                AudioManager.instance.PlaySFX(sfx_correct);
                Debug.Log("ACERTASTE");
                carta_A.interactuable(false);

                carta_B.interactuable(false);
                ACERTO.Invoke();
                limpiar_comparacion();
                carta_al_comparador.Clear();
            }
            else
            {
                AudioManager.instance.PlaySFX(sfx_error);
                Debug.Log("FALLASTE");
                carta_A.interactuable(true);
                carta_B.interactuable(true);
                FALLO.Invoke();
                //yield return new WaitForSeconds(1.0f);
                limpiar_comparacion();
            }
        }
    }

    public void agregar_carta(carta Card_value)
    {
        //SI LA LISTA NO ES IGUAL AL LIMITE QUE ES 2 
        //SE PUEDEN AGREGAR CARTA AL COMPARADOR
        if (carta_al_comparador.Count != limite)
        {
            carta_al_comparador.Add(Card_value);
            // SI CARTA A ESTA VACIA SE LE ASIGNA
            if (carta_A == null)
            {
                carta_A = Card_value;
                carta_A.interactuable(false);
            }
            //SI CARTA A NO ESTA VACIA Y CARTA B ESTA VACIA
            else if (carta_B == null)
            {
                carta_B = Card_value;
                comparar_cartas();
                carta_al_comparador.Clear(); 
            }

        }
    }

    public void limpiar_comparacion()
    {
        carta_A = null;
        carta_B = null;
    }

    IEnumerator esperar()
    {
        //SI AMBAS CARTAS TIENE EL MISMO ID ACIERTA
        if (carta_A.id_card == carta_B.id_card)
        {

            AudioManager.instance.PlaySFX(sfx_correct);
            Debug.Log("ACERTASTE");
            carta_A.interactuable(false);
            
            carta_B.interactuable(false);
            ACERTO.Invoke();
            limpiar_comparacion();
            carta_al_comparador.Clear();
        }
        else
        {
            AudioManager.instance.PlaySFX(sfx_error);
            Debug.Log("FALLASTE");
            carta_A.interactuable(true);
            carta_B.interactuable(true);
            FALLO.Invoke();
            yield return new WaitForSeconds(1.0f);
            limpiar_comparacion();
        }
    }
}
