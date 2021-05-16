using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringTheTurret : MonoBehaviour
{
    public GameObject Arrow;
    const float speed = 3000f;
    float fireDelay = 3f;
    AmmoForTurret Ammo;


    float Delay;






    /// <summary>
    /// ///////////////////////////////////////////////////////////
    /// </summary>
    private void Start()
    {
        Ammo = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<AmmoForTurret>();

    }

 

    void Update()
    {
  
        if (Input.GetButton("Fire1") && Time.time > Delay && Ammo.ammo >0)
        {
            Delay = Time.time + fireDelay;
            GameObject shotInstance = Instantiate(Arrow, transform.position, transform.rotation);
            shotInstance.GetComponent<Rigidbody>().AddForce((transform.forward *4*  speed));
            Ammo.ammo -= 1;

        }
       
       
    } 



}
