using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 10;
    public float turningSpeed = 60;
    public bool Switch = false;
    public Rigidbody Boy;
    public Rigidbody Girl;
    public float SwitchDelay;
    public float TimeToSwitch = 100f;
    public Camera CameraBoy;
    public Camera CameraGirl;
   

    public float jumpHeight = 100f;
    public bool isGrounded;
    public float horizontal;

    float SpeedBoost = 1;



    /// <summary>
    /// ///////////////////////////////Boss/////////////////////
    /// </summary>
    BossMechanics Boss;
    public Camera WaterTurret;
    public Rigidbody GirlBoss;








    void Awake()
    {
    }

    private void Start()
    {
        CameraGirl.enabled = true;
        CameraBoy.enabled = false;
        WaterTurret.enabled = false;
        Boss = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossMechanics>();

    }
    void Update()
    {
        if (Input.GetKeyUp("c") && Time.time > SwitchDelay)
        {
            
            Debug.Log("You Have changed character");
            if (Switch == true)
            {

                Switch = false;
                SwitchDelay = Time.time + TimeToSwitch;
                Debug.Log("Water Girl at the ready");
               


            }
            else if (Switch == false)
            {

                Switch = true;
                SwitchDelay = Time.time + TimeToSwitch;
              


            }
        }
        

        float horizontal = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;


        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;


        if (Switch == true)
        {
            if (Boss.Bossfight == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SpeedBoost = 5;
                    StartCoroutine(SpeedBoostwait(20000.0F));
                }
                    Girl.transform.Translate((horizontal*SpeedBoost), 0, (vertical* SpeedBoost));
                Girl.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
                CameraGirl.enabled = true;
                CameraBoy.enabled = false;
                
            }
            if (Boss.Bossfight == true)
            {
                GirlBoss.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
                CameraGirl.enabled = false;
                CameraBoy.enabled = false;
                WaterTurret.enabled = true;

            }
        }
        if (Switch == false)
        {
            {
                
                Boy.transform.Translate(horizontal, 0, vertical);
                Boy.transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
                CameraGirl.enabled = false;
                CameraBoy.enabled = true;
                WaterTurret.enabled = false;

            }
        }

        IEnumerator SpeedBoostwait(float SpeedBoostwait1)
        {
            yield return new WaitForSeconds(3);

            SpeedBoost = 1;

            Debug.Log("test");


        }

    }
   
    
}
