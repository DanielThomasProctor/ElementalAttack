using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyJump : MonoBehaviour
{

    public float jumpHeight = 100f;
    public bool isGrounded;
    public bool isGrounded1;
    public Rigidbody Boy;
    


    public float SwitchDelay;
    public float TimeToSwitch = 100;


    /// <summary>
    /// /////////////////////
    /// </summary>
    public GameObject Whichplayer;
    Movement WhichPlayer_script;
    private bool Switch1;

    /// <summary>
    /// /////////////////////////////////////
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {//////////////////
        WhichPlayer_script = Whichplayer.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {

        Switch1 = WhichPlayer_script.Switch;
        
        if (Switch1 == false)
        {
            if (isGrounded == true)
            {
                if (Input.GetKey("space"))
                {
                    Boy.AddForce(Vector3.up * jumpHeight);
                }
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
