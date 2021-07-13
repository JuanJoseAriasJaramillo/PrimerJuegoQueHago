using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionScriptN : MonoBehaviour
{
    public bool willItRainToday = false;
     // Start is called before the first frame update
    void Start()
    {
        /*if (willItRainToday)
        {
            Debug.Log("No te olvides de coger el paraguas");

        }
        else
        {
            Debug.Log("No lo cojas, hace mucho sol");
        }*/

        /*if (!willItRainToday)
        {
            Debug.Log("Vamos al cine");
        }*/
        bool iAmLate = true;
        bool isThereSomeTraffic = false;
        if(iAmLate && !isThereSomeTraffic)
        {
            Debug.Log("pisa que vas tarde");
        }
        bool iAmHungry = true;
        bool kidsAreHungry = false;
        if(iAmHungry || kidsAreHungry)
        {
            Debug.Log("vamos a hacer la comida");
        }
        else
        {
            Debug.Log("Nadie tiene hambre");
        }

        int maxSpeed = 120;
        if(maxSpeed == 120){

            Debug.Log("Podemos ir a fondo!");

        }else if(maxSpeed<120 && maxSpeed >= 60){

            Debug.Log("Podemos ir a velocidad de cruce!");

        }else if(maxSpeed>60 && maxSpeed <= 40) {
            Debug.Log("Debemos ir a velocidad de ciudad");
        }
        else if(maxSpeed<40 && maxSpeed>= 0)
        {
            Debug.Log("Mejor vamos a dando un paseo...");
        }
        else
        {
            Debug.LogError("Velocidad no valida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
