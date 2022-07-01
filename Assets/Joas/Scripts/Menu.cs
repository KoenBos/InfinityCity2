using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject playerController;
    public GameObject menuPanel;
    public GameObject settingsPanel;
    public GameObject eelUI;
    public bool freezePlayer;
    public Animator animator;


    void Start()
    { 
        freezePlayer = false;
        settingsPanel.SetActive(false);
        menuPanel.SetActive(false);
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
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    
    public void ExitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
     public void OpenOptions()
    {
        if (animator != null)
        {
            animator.SetBool("OpenOptions", true);
        }
    }
    public void ExitOptions()
    {
        if (animator != null)
        {
            animator.SetBool("OpenOptions", false);
        }
    }


}
