using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class PlayerInventory : MonoBehaviour
{
   [SerializeField]
   public int NumberOfEels { get; private set; }
   
   public GameObject particleSystem;

   public UnityEvent<PlayerInventory> OnEelCollected;

   public int health;

   public Slider slider;

   public Gradient gradient;

   public Image fill;

   public int EelInGenerator;

   public GameObject Lamp1R;
   public GameObject Lamp2R;
   public GameObject Lamp3R;
   public GameObject Lamp4R;
   public GameObject Lamp1G;
   public GameObject Lamp2G;
   public GameObject Lamp3G;
   public GameObject Lamp4G;


   void Awake()
    {
        fill.color = gradient.Evaluate(1f);
        
    }
   

   public void EelCollected()
   {
       NumberOfEels++;
       OnEelCollected.Invoke(this);
   }

   public void OnDamaged()
   {
       health--;
       slider.value = health;
       fill.color = gradient.Evaluate(slider.normalizedValue);
   }

   public void EelDesposited()
   {
       if (NumberOfEels > 0) 
       {
        
       NumberOfEels--;
       OnEelCollected.Invoke(this);
       particleSystem.SetActive(true);
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
       else 
       {
        particleSystem.SetActive(false);
       }
   }


}
