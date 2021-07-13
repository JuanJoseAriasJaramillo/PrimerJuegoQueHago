using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    /*
     * Seccion de variables
     * 
     */
    public int number1 = 5;
    public int number2 = 8;


    private void Awake()
    {
        Debug.Log("El bojeto ha despertado");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El objeto ha arrancado");
        AddTwoNumbers(5, 8);

        string myMessage = HelloMe("juan José);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("El objeto se está actualizando");
        
        if (Input.GetKeyDown(KeyCode.Return)){
            AddTwoGlobalNumbers(80, 20);
        }
    }    
    void AddTwoGlobalNumbers() {
        Debug.Log(number1 + number2)
    }
    void AddTwoNumbers(int firstNumber, int secondNumber)
    {
        Debug.Log(firstNumber + secondNumber);
    }
    string SayHello(string username)
    {

    }
    string HelloMe(string username)
    {
        string message1 = "Bienvenido al curso " + username;
        return message1;
    }
}
    
