using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject enemigo; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DecideSiEnemigo(); 
    }


    private void DecideSiEnemigo() { 

        float random = Random.Range(0.0f, 100.0f);
        if(random < 1.0f){
            GameObject.Instantiate(enemigo, transform.position, transform.rotation); 
        }

    }
}
