using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);

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
    public void ExitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
