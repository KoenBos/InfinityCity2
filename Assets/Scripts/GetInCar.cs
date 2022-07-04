using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class GetInCar : MonoBehaviour
{
    public static GameObject raycar;

    public Camera cam;
    public CinemachineFreeLook cinemachine;
    public GameObject player;

    public GameObject saveCar;

    public GameObject carsound;

    public GameObject ishowspeedUI;

    // Vergeet niet vraag om een nieuwe gameobject aan te maken.
    //\
    //CarController carController = new CarController();

    // Data of RayCast
    RaycastHit hitData;

    public bool PlayerInCar;


    // Start is called before the first frame update
    void Start()
    {
        PlayerInCar = false;
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

        // copyCar = GameObject.Instantiate(raycar);

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
            cinemachine = raycar.GetComponentInChildren<CinemachineFreeLook>();

            if (raycar == raycar.CompareTag("Car"))
            {
                saveCar = raycar;

            }
        }

    }


    public void Inside()
    {
        // StartCoroutine(InsideFunction());

        // reset car drag to move
        saveCar.GetComponent<Rigidbody>().drag = 0;
        ishowspeedUI.SetActive(true);
        cinemachine.enabled = true;
        player.SetActive(false);
        PlayerInCar = true;
        saveCar.GetComponent<CarController>().enabled = true;
        saveCar.GetComponentInChildren<Camera>().enabled = true;
        saveCar.GetComponent<AudioSource>().enabled = true;
        saveCar.GetComponent<CarSound>().enabled = true;
        carsound.SetActive(true);
        cam.GetComponent<AudioListener>().enabled = true;

    }
    public void Outside()
    {
        ishowspeedUI.SetActive(false);
        cinemachine.enabled = false;
        cam.enabled = false;
        player.SetActive(true);
        PlayerInCar = false;
        player.transform.position = raycar.transform.position;
        carsound.SetActive(false);
        cam.GetComponent<AudioListener>().enabled = false;

        StartCoroutine(SlowCarDown());

    }

    IEnumerator SlowCarDown()
    {
        yield return new WaitForSeconds(1f);
        saveCar.GetComponent<CarController>().enabled = false;
        yield return new WaitForSeconds(0.01f);
        // car drag to slow the car
        saveCar.GetComponent<Rigidbody>().drag = 100;
        saveCar.GetComponent<AudioSource>().enabled = false;
        saveCar.GetComponent<CarSound>().enabled = false;
    }
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
