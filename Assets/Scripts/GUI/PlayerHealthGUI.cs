using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthGUI : MonoBehaviour
{

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI staminaText;

    // Start is called before the first frame update
    void Start()
    {
        healthText.GetComponent<TextMeshProUGUI>().text = "Health = " + GetComponent<PlayerHealthAndStamina>().playerHealth;
        staminaText.GetComponent<TextMeshProUGUI>().text = "Stamina = " + GetComponent<PlayerHealthAndStamina>().playerStamina;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

}
