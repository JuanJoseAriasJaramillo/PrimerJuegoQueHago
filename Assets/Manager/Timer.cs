using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime = 60f;
    private float countDown = 0f;
    // Start is called before the first frame update
    void Start()
    {
        countDown = maxTime;
    }

    // Update is called once per frame
    void Update()
    {   //es el tiempo en segundos que ha pasado desde que se renderiz� en pantalla el �ltimo frame anterior.
        countDown -= Time.deltaTime;
        Debug.Log("Cuenta atr�s: " + countDown);
        if(countDown <= 0)
        {
            Debug.Log("Te has quedado sin tiempo... HAS PERDIDO!!!!");
            Coin.coinsCount = 0;

            SceneManager.LoadScene("MainScene");
        }
    }
}
