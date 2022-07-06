using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{


    public int EelInGenerator;
    public GameObject Lamp1R1;
    public GameObject Lamp2R1;
    public GameObject Lamp3R1;
    public GameObject Lamp4R1;
    public GameObject Lamp1G;
    public GameObject Lamp2G1;
    public GameObject Lamp3G1;
    public GameObject Lamp4G1;
    public GameObject Lamp1R2;
    public GameObject Lamp2R2;
    public GameObject Lamp3R2;
    public GameObject Lamp4R2;
    public GameObject Lamp1G2;
    public GameObject Lamp2G2;
    public GameObject Lamp3G2;
    public GameObject Lamp4G2;
    public GameObject Lamp1R3;
    public GameObject Lamp2R3;
    public GameObject Lamp3R3;
    public GameObject Lamp4R3;
    public GameObject Lamp1G3;
    public GameObject Lamp2G3;
    public GameObject Lamp3G3;
    public GameObject Lamp4G3;
    public GameObject Lamp1R4;
    public GameObject Lamp2R4;
    public GameObject Lamp3R4;
    public GameObject Lamp4R4;
    public GameObject Lamp1G4;
    public GameObject Lamp2G4;
    public GameObject Lamp3G4;
    public GameObject Lamp4G4;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
     public GameObject congratsPanel;
    

    public PlayerInventory PlayerInventory;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TriggerGenerator()
    {
       EelInGenerator++;

       if (EelInGenerator == 1)
       {
        Lamp1R1.SetActive(false);
        Lamp1G.SetActive(true);
       }
       if (EelInGenerator == 2)
       {
        Lamp2R1.SetActive(false);
        Lamp2G1.SetActive(true);
       }
       if (EelInGenerator == 3)
       {
        Lamp3R1.SetActive(false);
        Lamp3G1.SetActive(true);
       }
       if (EelInGenerator == 4)
       {
        Lamp4R1.SetActive(false);
        Lamp4G1.SetActive(true);
        door1.SetActive(false);
       }
       if (EelInGenerator == 5)
       {
        Lamp1R2.SetActive(false);
        Lamp1G2.SetActive(true);
       }
       if (EelInGenerator == 6)
       {
        Lamp2R2.SetActive(false);
        Lamp2G2.SetActive(true);
       }
       if (EelInGenerator == 7)
       {
        Lamp3R2.SetActive(false);
        Lamp3G2.SetActive(true);
       }
       if (EelInGenerator == 8)
       {
        Lamp4R2.SetActive(false);
        Lamp4G2.SetActive(true);
        door2.SetActive(false);
       }
       if (EelInGenerator == 9)
       {
        Lamp1R3.SetActive(false);
        Lamp1G3.SetActive(true);
       }
       if (EelInGenerator == 10)
       {
        Lamp2R3.SetActive(false);
        Lamp2G3.SetActive(true);
       }
       if (EelInGenerator == 11)
       {
        Lamp3R3.SetActive(false);
        Lamp3G3.SetActive(true);
       }
       if (EelInGenerator == 12)
       {
        Lamp4R3.SetActive(false);
        Lamp4G3.SetActive(true);
        door3.SetActive(false);
       }
       if (EelInGenerator == 13)
       {
        Lamp1R4.SetActive(false);
        Lamp1G4.SetActive(true);
       }
       if (EelInGenerator == 14)
       {
        Lamp2R4.SetActive(false);
        Lamp2G4.SetActive(true);
       }
       if (EelInGenerator == 15)
       {
        Lamp3R4.SetActive(false);
        Lamp3G4.SetActive(true);
       }
       if (EelInGenerator == 16)
       {
        Lamp4R4.SetActive(false);
        Lamp4G4.SetActive(true);
        congratsPanel.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
       }
       
   }
}
