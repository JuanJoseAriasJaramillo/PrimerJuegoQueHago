using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{
    public string firstNamme = "Juan";
    public string lastName = "Arias";
    public string email = "juanjoseariasj@hotmail.com";
    public int age = 32;
    public float height = 1.87f;
    public float weight = 82.5f;
    // Start is called before the first frame update
    
    void Start()
    {
        float playerHeight = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
