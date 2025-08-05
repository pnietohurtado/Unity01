using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool saltando;
    private int hp;
    public GameObject attack;
    public GameObject posicion; 

    void Start()
    {
        saltando = false;
        hp = 3; 
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.1f, 0.0f)); 
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.1f, 0.0f));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // transform.Translate(new Vector3(0.0f, 0.1f)); 
            if (saltando == false)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 500.0f));
                saltando = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            GameObject.Instantiate(attack, posicion.transform.position, posicion.transform.rotation); 
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            saltando = false;
        }

        else if(collision.gameObject.tag == "Enemy")
        {
            
            collision.gameObject.SetActive(false); 
            Destroy(collision.gameObject, 0.5f);
            hp--; 

            if(hp <= 0)
            {
                Debug.Log("El jugador ha muerto"); 
                gameObject.SetActive(false);
            }
            
        }
    }

}
