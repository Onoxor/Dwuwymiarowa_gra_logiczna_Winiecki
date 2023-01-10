using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour
{
    public string LevelName;
    public int spectrum;
    //public int LevelIndex;


    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
        PointManager.instance.AddPoint(spectrum);
        //Debug.Log("Collision Detected");
        if (other.gameObject.tag == "Player")
            SceneManager.LoadScene(LevelName);
        
    }
}
