using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public GameObject flashlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.F) && (flashlight.activeInHierarchy))
        {
            flashlight.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.SetActive(true);
        }
        

    }
}
