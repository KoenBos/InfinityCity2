using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class Title_Screen_Script : MonoBehaviour
{
    public GameObject Panel_Afsluiten;

    void Start()
    {
        if (Panel_Afsluiten != null)
        {
            Panel_Afsluiten.SetActive(false);
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

    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }
}


