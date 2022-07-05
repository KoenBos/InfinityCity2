using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{


    public int EelInGenerator;
    public GameObject Lamp1R;
    public GameObject Lamp2R;
    public GameObject Lamp3R;
    public GameObject Lamp4R;
    public GameObject Lamp1G;
    public GameObject Lamp2G;
    public GameObject Lamp3G;
    public GameObject Lamp4G;
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

       if (EelInGenerator == 1){
        Lamp1R.SetActive(false);
        Lamp1G.SetActive(true);
       }
       if (EelInGenerator == 2){
        Lamp2R.SetActive(false);
        Lamp2G.SetActive(true);
       }
       if (EelInGenerator == 3){
        Lamp3R.SetActive(false);
        Lamp3G.SetActive(true);
        Lamp4R.SetActive(false);
        Lamp4G.SetActive(true);
       }

   }
}
