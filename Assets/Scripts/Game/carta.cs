using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class carta : MonoBehaviour
{
    Button btn_card;
    TextMeshProUGUI text_card;
    public string nombre_carta;
    public int id_card;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        btn_card.interactable = value;
        return;
    }
}
