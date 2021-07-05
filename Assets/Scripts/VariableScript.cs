using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    /*
     * Seccion de variables
     * 
     */

    public int myNumber = 30;

    public int total;
    // Start is called before the first frame update
    void Start()
    {
        total = myNumber - 5;// total = 25
        Debug.Log(total);
        Debug.Log(6 + 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
