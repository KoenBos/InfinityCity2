using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetInCar : MonoBehaviour
{
    public GameObject raycar;

    public GameObject Car;

    public Camera cam;
    public GameObject player;


    // Vergeet niet vraag om een nieuwe gameobject aan te maken.
    //

    // Data of RayCast
    RaycastHit hitData;

    public bool PlayerInCar { get; set; }

    [SerializeField] private Material highlightMaterial;


    // Start is called before the first frame update
    void Start()
    {
        PlayerInCar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            if (!PlayerInCar)
            {
                Inside();
            }
            else
            {
                Outside();
            }
        }

        if (!PlayerInCar)
        {
            RayCastForPlayer();
        }
    }
    void RayCastForPlayer()
    {
        // Creates a Ray from the center of the viewport
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        // Gets a Game Object reference from its Transform
        Debug.DrawRay(ray.origin, ray.direction * 3);

        // if Ray hit out hitdata
        if (Physics.Raycast(ray, out hitData))
        {
            raycar = hitData.transform.gameObject;
            cam = raycar.GetComponentInChildren<Camera>();
        }

    }


    public void Inside()
    {
        // StartCoroutine(InsideFunction());
        cam.enabled = true;
        player.SetActive(false);
        PlayerInCar = true;
    }
    public void Outside()
    {
        // StartCoroutine(OutsideFunction());
        cam.enabled = false;
        player.SetActive(true);
        PlayerInCar = false;
        player.transform.position = raycar.transform.position;

    }

    // IEnumerator InsideFunction()
    // {
    //     yield return new WaitForSeconds(0.01f);
    //     raycar.GetComponent<CarController>().enabled = true;
    //     yield return new WaitForSeconds(0.01f);
    //     cam.enabled = true;
    //     player.SetActive(false);
    //     PlayerInCar = true;
    // }

    // IEnumerator OutsideFunction()
    // {
    //     yield return new WaitForSeconds(0.01f);
    //     player.transform.position = raycar.transform.position;
    //     yield return new WaitForSeconds(0.01f);
    //     raycar.GetComponent<CarController>().enabled = false;
    //     cam.enabled = false;
    //     player.SetActive(true);
    //     PlayerInCar = false;

    // }
}
