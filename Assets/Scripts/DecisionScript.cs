using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionScript : MonoBehaviour
{
    public bool willItRainToday = false;
    // Start is called before the first frame update
    void Start()
    {
        if (willItRainToday)
        {
            Debug.Log("No te olvides coger el paraguas");
        }
        else
        {
            Debug.Log("No lo cojas, que hjace muchjo calor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
