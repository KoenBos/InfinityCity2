using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EelJaw : MonoBehaviour
{
    private Vector3 GrapplePoint;
    public LayerMask Grappleable;
    private LineRenderer linerender;
    

    

    // Start is called before the first frame update
    void Start()
    {
        Grappleable = GetComponent<LayerMask>();
        linerender = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Grapple();
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            StopGrapple();
        }

        
    }
    //When you press Q, you initiate the Eel Jaws' grapple function
    private void Grapple()
    {
        
    }
     //When you let go of Q, you stop using the Eel Jaws' grapple function
    private void StopGrapple()
    {
        
    }
}
