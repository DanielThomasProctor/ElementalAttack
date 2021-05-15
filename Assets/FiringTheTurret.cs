using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringTheTurret : MonoBehaviour
{
    public GameObject Arrow;
    const float speed = 3000f;
    float fireDelay = 3f;
   


    float Delay;






    /// <summary>
    /// ///////////////////////////////////////////////////////////
    /// </summary>
    private void Start()
    {


    }

 

    void Update()
    {
  
        if (Input.GetButton("Fire1") && Time.time > Delay)
        {
            Delay = Time.time + fireDelay;
            GameObject shotInstance = Instantiate(Arrow, transform.position, transform.rotation);
            shotInstance.GetComponent<Rigidbody>().AddForce((transform.forward *4*  speed));


        }
       
       
    } 



}
