using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCar : MonoBehaviour
{
    public GameObject objectActiveAndDeactive;
    public GameObject car;
    public GameObject player;

    public bool PlayerInCar = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PlayerInCar == false)
        {
            Inside();
            PlayerInCar = true;
        }
        if (Input.GetKeyDown(KeyCode.G) && PlayerInCar == true)
        {
            Outside();
            PlayerInCar = false;
        }
    }
    public void Inside()
    {
        car.GetComponent<CarController>().enabled = true;
        objectActiveAndDeactive.SetActive(false);
    }
    public void Outside()
    {
        player.transform.position = car.transform.position;
        car.GetComponent<CarController>().enabled = false;
        objectActiveAndDeactive.SetActive(true);
    }
}
