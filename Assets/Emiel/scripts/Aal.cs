using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Aal : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
       PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

       if(playerInventory != null)
       {
           playerInventory.EelCollected();
           gameObject.SetActive(false);
       }
   }
}
