using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public static PointManager instance;
    public int altruism = 0;
    public int conformism = 0;
    public int rationalism = 0;
    public int courage = 0;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        instance = this;
    }
    public void AddPoint(int spectrum)
    {
        switch (spectrum)
        {
            case 1:
                altruism++;
                Debug.Log(altruism);
                break;
            case 2:
                conformism++;
                break;
            case 3:
                rationalism++;
                break;
            case 4: courage++;
                break;
            case 5:
                altruism--;
                break;
            case 6:
                conformism--;
                break;
            case 7:
                rationalism--;
                break;
            case 8: 
                courage--;
                break;
            default:
                break;

        }

    }
}
