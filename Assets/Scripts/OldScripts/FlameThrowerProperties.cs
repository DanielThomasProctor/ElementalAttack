using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrowerProperties : MonoBehaviour
{
    
    void OnCollisionEnter( Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("nemy"))
        {

            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Flames")
        {
            Destroy(collision.collider.gameObject);
            //Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Flame"))
        {

            Destroy(collision.collider.gameObject);
           // Destroy(gameObject);
        }

    }
   
} 

