using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class carta : MonoBehaviour
{
    public AudioClip sfx_mouuse_enter;
    Button btn_card;
    TextMeshProUGUI text_card;
    public Comparador_manager comparador_ref;
    public Animator animator_card;
    public string nombre_carta;
    public int id_card;
    bool can_interacte;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator_card = GetComponent<Animator>();
        comparador_ref = FindFirstObjectByType<Comparador_manager>();
        btn_card = GetComponent<Button>();
        text_card = GetComponentInChildren<TextMeshProUGUI>();
        text_card.text = nombre_carta;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void interactuable(bool value)
    {
        print(value);
        btn_card.interactable = value;
        if (btn_card.interactable == false)
        {
            animator_card.SetBool("interactuable", false);
            //animator_card.Play("Hide"); 
        }
        else if (btn_card.interactable == true)
        {
            animator_card.SetBool("interactuable", true);
            //animator_card.Play("Show");
        }
        return;
    }
    

    public void play_sfx_enter()
    {

        AudioManager.instance.PlaySFX(sfx_mouuse_enter);
    }

    public void agregar_carta()
    {
        comparador_ref.agregar_carta(this);
    }

    public void seleccionar()
    {

    }
    
}
