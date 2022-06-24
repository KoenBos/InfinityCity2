using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActivation : MonoBehaviour
{
    private Animator animator;
    public GameObject playerController;
    public GameObject menuPanel;
    public GameObject eeltext;
    public GameObject eelimage;
    public GameObject interactorCursor;
    public bool freezePlayer;

    void Start()
    {
        animator.GetComponent<Animator>();
        playerController.GetComponent<GameObject>();
        menuPanel.GetComponent<GameObject>();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && freezePlayer == false)
        {
            Inside();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        if (Input.GetKeyDown(KeyCode.T) && freezePlayer == true)
        {
            Outside();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void Inside()
    {
        StartCoroutine(InsideFunction());
    }

    IEnumerator InsideFunction()
    {
        yield return new WaitForSeconds(0.01f);
        playerController.SetActive(false);
        eeltext.SetActive(false);
        eelimage.SetActive(false);
        interactorCursor.SetActive(false);
        menuPanel.SetActive(true);
        freezePlayer = true;
    }
    public void Outside()
    {
        StartCoroutine(OutsideFunction());
    }
    IEnumerator OutsideFunction()
    {
        yield return new WaitForSeconds(0.01f);
        playerController.SetActive(true);
        eeltext.SetActive(true);
        eelimage.SetActive(true);
        interactorCursor.SetActive(true);
        menuPanel.SetActive(false);
        freezePlayer = false;

    }

}
