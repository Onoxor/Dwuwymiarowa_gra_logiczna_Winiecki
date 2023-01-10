using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChestOpenTrigger : MonoBehaviour
{

    public GameObject blockade1, blockade2;
    public Animator animator;


    public void OnTriggerEnter2D(Collider2D other)
    {
        animator.SetTrigger("Enter_area");
        blockade1.SetActive(true);
        blockade2.SetActive(false);

    }
}
