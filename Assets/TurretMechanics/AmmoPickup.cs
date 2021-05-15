using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    AmmoForTurret Ammo;
    // Start is called before the first frame update
    void Start()
    {
        Ammo = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<AmmoForTurret>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {


            Debug.Log("Projectile collected");

            Ammo.ammo += 1;


         
            Destroy(this.gameObject);


        }


    }
}
