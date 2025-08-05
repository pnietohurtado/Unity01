using UnityEngine;

public class EliminateEnemy : MonoBehaviour
{
    private void Start()
    {
        
    }


    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SetActive(false); // Desactivar el objeto, es decir que no se vea
            Destroy(collision.gameObject , 0.1f);  // Se encarga de destruir el personaje, con un retardo para que no realentice el juego
        }
    }
}
