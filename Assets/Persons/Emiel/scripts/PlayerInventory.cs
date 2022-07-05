using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class PlayerInventory : MonoBehaviour
{
    public Generator Generator;
   [SerializeField]
   public int NumberOfEels { get; private set; }
   
   public GameObject pparticleSystem;

   public UnityEvent<PlayerInventory> OnEelCollected;

   public int health;

   public Slider slider;

   public Gradient gradient;

   public Image fill;


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
       pparticleSystem.SetActive(true);
       Generator.TriggerGenerator();
       
       }
       else 
       {
        pparticleSystem.SetActive(false);
       }
   }


}
