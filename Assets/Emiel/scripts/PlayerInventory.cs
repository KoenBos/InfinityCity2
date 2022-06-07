using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerInventory : MonoBehaviour
{
   public int NumberOfEels { get; private set; }

   public UnityEvent<PlayerInventory> OnEelCollected;

   public void EelCollected()
   {
       NumberOfEels++;
       OnEelCollected.Invoke(this);
   }
}
