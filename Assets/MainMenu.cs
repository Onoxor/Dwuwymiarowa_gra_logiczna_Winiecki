using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        var objs = GameObject.FindGameObjectsWithTag("Manager");
        if (objs.Length > 0)
        {
            foreach(var obj in objs)
            {
                Destroy(obj);
            }
        }
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
