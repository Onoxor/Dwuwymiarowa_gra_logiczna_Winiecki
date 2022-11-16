using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject textBox;
    public Dialogue dialogue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("TextBox activated!");
            textBox.SetActive(false);
            textBox.SetActive(true);
            textBox.GetComponent<Dialogue>().enabled = true;
            dialogue.Start();
            
        }
            
    }

}
