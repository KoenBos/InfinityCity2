using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI eeltext;
    // Start is called before the first frame update
    void Start()
    {
       eeltext = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateEelText(PlayerInventory playerInventory)
    {
        eeltext.text = playerInventory.NumberOfEels.ToString();
    }
}
