using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActivation : MonoBehaviour
{
    private Animator animator;
    public GameObject playerController;
    public GameObject menuPanel;
    public GameObject eelUI;
    public bool freezePlayer;

    void Start()
    {
        animator.GetComponent<Animator>();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && freezePlayer == false)
        {
            Inside();
        }
        if (Input.GetKeyDown(KeyCode.T) && freezePlayer == true)
        {
            Outside();
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
        eelUI.SetActive(false);
        menuPanel.SetActive(true);
        freezePlayer = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void Outside()
    {
        StartCoroutine(OutsideFunction());
    }
    IEnumerator OutsideFunction()
    {
        yield return new WaitForSeconds(0.01f);
        playerController.SetActive(true);
        eelUI.SetActive(true);
        menuPanel.SetActive(false);
        freezePlayer = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
    public void ContinueGame()
    {   
            playerController.SetActive(true);
            eelUI.SetActive(true);
            menuPanel.SetActive(false);
            freezePlayer = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }

}
