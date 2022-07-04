using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CheckParticles : MonoBehaviour
{
    private ParticleSystem ps;
    

    public UnityEvent<CheckParticles> OnThunder;

  // Use this for initialization
  void Start()
  {
    ps = GetComponent<ParticleSystem>();

  }

  // Update is called once per frame
  void Update()
  {
   
   if (ps.particleCount > 1)
   {
     for(int i = 0; i < ps.particleCount; i++)
        {
           OnThunder.Invoke(this);
        }
    
   }
  
  }

  
}
