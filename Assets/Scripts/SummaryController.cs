using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SummaryController : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public GameObject textbox, text;

    private string texttodisplay="";
    private int altruism = 0;
    private int conformism = 0;
    private int rationalism = 0;
    private int courage = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pointManager = GameObject.Find("PointManager");

        altruism = pointManager.GetComponent<PointManager>().altruism;
        conformism = pointManager.GetComponent<PointManager>().conformism;
        rationalism = pointManager.GetComponent<PointManager>().rationalism;
        courage = pointManager.GetComponent<PointManager>().courage;
        Debug.Log(altruism);
        Debug.Log(conformism);
        Debug.Log(rationalism); 
        Debug.Log(courage);

        if (altruism > 0)
        {
            UpdateText("Jeste� Altruist�. ");
        }
        else
        {
            UpdateText("Jeste� Egoist�. ");
        }

        if(conformism > 0)
        {
            UpdateText("Jeste� Konformist�. ");
        }
        else
        {
            UpdateText("Jeste� nonkonformist�. ");
        }

        if(rationalism> 0)
        {
            UpdateText("Jeste� racjonalist�. ");
        }
        else
        {
            UpdateText("Jeste� empiryst�. ");
        }

        if(courage> 0)
        {
            UpdateText("Jeste� odwa�ny. ");
        }
        else
        {
            UpdateText("Jeste� tch�rzliwy. ");
        }


        textComponent.SetText(texttodisplay);
    }

    void UpdateText(string text)
    {
        texttodisplay += text;
    }
}
