using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float jumpHeight = 100f;
    public bool isGrounded;
    public bool isGrounded1;
    public Rigidbody Boy;
    public Rigidbody Girl;

    
    public float SwitchDelay;
    public float TimeToSwitch = 100;


    /// <summary>
    /// /////////////////////
    /// </summary>
    public GameObject Whichplayer;
    Movement WhichPlayer_script;
    bool Switch1;

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
        if (Switch1== true) {
            if (isGrounded1 == true)
            {
                if (Input.GetKey("space"))
                {
                    Girl.AddForce(Vector3.up * jumpHeight);
                }
            }

        }
        
        if (Switch1 == false) {
            if (isGrounded== true)
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
        if (this.gameObject.tag == "Fire")
        {
            if (other.gameObject.tag == "Ground")
            {
                isGrounded = true;
            }
        }
        if (this.gameObject.tag == "Water")
        {
            if (other.gameObject.tag == "Ground")
            {
                isGrounded1 = true;
            }
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (this.gameObject.tag == "Fire")
        {
            if (other.gameObject.tag == "Ground")
            {
                isGrounded = false;
            }
        }
        if (this.gameObject.tag == "Water")
        {
            if (other.gameObject.tag == "Ground")
            {
                isGrounded1 = false;
            }
        }
        
    }
}
