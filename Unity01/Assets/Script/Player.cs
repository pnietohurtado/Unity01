using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        
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

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0.0f, 500.0f));
        }

    }

}
