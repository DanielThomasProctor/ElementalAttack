using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump2 : MonoBehaviour
{
    public float jumpHeight = 100f;
    public bool isGrounded;
    public Rigidbody Girl;
    public int i;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //public void UpdateGrounded(int isGrounded)
    //{
      //  i = 1;
    //}

    // Update is called once per frame
    void Update()
    {
        
        if (isGrounded)
        {
            if (Input.GetKey("space"))
            {
                Girl.AddForce(Vector3.up * jumpHeight);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
