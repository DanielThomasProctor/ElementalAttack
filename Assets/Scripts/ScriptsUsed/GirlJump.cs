using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlJump : MonoBehaviour
{

    public float jumpHeight = 500f;
    public bool isGrounded;
    public bool isGrounded1;
    public Rigidbody Girl;



    public float SwitchDelay;
    public float TimeToSwitch = 100;


    /// <summary>
    /// /////////////////////
    /// </summary>
    public GameObject Whichplayer;
    Movement WhichPlayer_script;
    bool Switch1;
    float Movement1;
    /// <summary>
    /// /////////////////////////////////////
    /// </summary>
    private bool canDoubleJump;


    public GameObject Water;
    public bool waterCheck;
    // Start is called before the first frame update
    void Start()
    {//////////////////
        WhichPlayer_script = Whichplayer.GetComponent<Movement>();
        Water.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Movement1 = WhichPlayer_script.horizontal;
        Switch1 = WhichPlayer_script.Switch;

        if (Switch1 == true)
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isGrounded == true)
                {
                    Girl.AddForce(Vector3.up * jumpHeight);
                    Debug.Log("Jump");
                }
                else
                {
                    if (canDoubleJump == true)
                    {
                        Water.SetActive(true);
                        Girl.AddForce(Vector3.up * jumpHeight);
                        canDoubleJump = false;
                        Debug.Log("Jump2");
                    }
                }
                

            }
            

            } 
    }
        void OnCollisionEnter(Collision other)
        {

            if (other.gameObject.tag == "Ground")
            {
                isGrounded = true;
                canDoubleJump = true;
            Water.SetActive(false);
        }



        }

        void OnCollisionExit(Collision other)
        {

            if (other.gameObject.tag == "Ground")
            {
             isGrounded = false;
            canDoubleJump = true;
            
        }



        }
    }

