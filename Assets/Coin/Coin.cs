
/*
 * NAMESPACE
 */
using System.Collections;
using UnityEngine;


/*
 * CLASS
 */
public class Coin : MonoBehaviour
{
    //PROPIEDADES Y MÉTODOS
    //Variable global y estatica (una para todas las monedas)

    public static int coinsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El juego ha comenzado");
        Coin.coinsCount++;
        Debug.Log("El juego ha comenzado y ahora hay " + Coin.coinsCount + " monedas");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Estamos en el Update");
        
    }
    /*Método que se llama automásticamente cuando otro collider entra en contacto con el que tiene
    este script (en particular la moneda)
    */
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true)
        {            
            //como el jugador choca contra una moneda ahora hay una menos
            Coin.coinsCount--;
            Debug.Log("Hemos recogido la moneda y ahora hay " + Coin.coinsCount + " monedas");
            //En el caso de que el contaodr de monedas llegue a cero, hemos recogido todo!
            if(Coin.coinsCount == 0)
            {
                Debug.Log("El juego ha terminado");
                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager);
                GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
                foreach(GameObject fireworks in fireworksSystem)
                {
                    fireworks.GetComponent<ParticleSystem>().Play();
                }
            }
            Destroy(gameObject);
        }
    }

}
