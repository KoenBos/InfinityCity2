using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInventory : MonoBehaviour
{
   [SerializeField]
   public int NumberOfEels { get; private set; }
   

   public UnityEvent<PlayerInventory> OnEelCollected;
   
  


   public void EelCollected()
   {
       NumberOfEels++;
       OnEelCollected.Invoke(this);
   }

   public void EelDesposited()
   {
       if (NumberOfEels > 0) 
       {
       NumberOfEels--;
       OnEelCollected.Invoke(this);
       
       }
   }


}
