using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Animator animator;
    public GameObject player;
    public bool freezePlayer;
    void Start()
    {
        //Set the animator in the inspector
        animator.GetComponent<Animator>();
        player.GetComponent<GameObject>();
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && freezePlayer == false)
        {
            Inside();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && freezePlayer == true)
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
        player.SetActive(false);
        freezePlayer = true;

    }
    public void Outside()
    {
        StartCoroutine(OutsideFunction());
    }
    IEnumerator OutsideFunction()
    {
        yield return new WaitForSeconds(0.01f);
        player.SetActive(true);
        freezePlayer = false;

    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    
    public void OpenMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (animator != null)
            {
                animator.SetBool("OpenMenu", true);
                
            }
        }
    }
    public void ExitMenu()
    {
        if (animator != null)
        {
            animator.SetBool("OpenMenu", false);
        }
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
