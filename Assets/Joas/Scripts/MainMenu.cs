using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    private Animator animator;
    
    void Start()
    {
        //Set the animator in the inspector
        animator.GetComponent<Animator>();
    }

    //This function is for loading another scene via a button, you can change this setting in the inspector.
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    //This function opens the panel for the main menu, this will pause your game.
    //if the esc. key is pressed and if the animator is active, then the animator will set the given Bool to true. This action can be performed by the press of a button.
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

    //If the animator is active, then the animator will set the given Bool to true. This action can be performed by the press of a button.
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
