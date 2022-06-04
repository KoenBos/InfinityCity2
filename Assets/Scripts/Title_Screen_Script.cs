using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class Title_Screen_Script : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    public void ExitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);

    }
    public void GoToCredits()
    {
        if (animator != null)
        {
            animator.SetBool("GoCredits", true);
        }
    }
    public void ExitCredits()
    {
        if (animator != null)
        {
            animator.SetBool("GoCredits", false);
        }
    }
    public void GoToOptions()
    {
        if (animator != null)
        {
            animator.SetBool("GoOptions", true);
        }
    }
    public void ExitOptions()
    {
        if (animator != null)
        {
            animator.SetBool("GoOptions", false);
        }
    }
}


