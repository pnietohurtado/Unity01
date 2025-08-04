using System.Linq.Expressions;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool saltando; 

    void Start()
    {
        saltando = false;    
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
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 50.0f));
                saltando = true;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            saltando = false;
        }
    }

}
