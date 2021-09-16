using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    float speed = -3f;
    float speedRotation = 0.5f;
    float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButton("Vertical"))
        {
            float vert = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, vert * speed);
        }
        if (Input.GetButton("Horizontal"))
        {
            float hor = Input.GetAxis("Horizontal");
            rb.velocity = new Vector3(hor * speed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            transform.Rotate(Vector3.up * -speedRotation);
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(Vector3.up * speedRotation);
        }
        if (Input.GetButton("Jump"))
        {
            rb.AddRelativeForce(Vector3.up * jumpForce);
        }
    }
}
