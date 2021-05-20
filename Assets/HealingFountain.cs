using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingFountain : MonoBehaviour
{
    PlayerHealth health;
    public float Delay =(2f);
    public float HealDelay;
    public bool healing;
    // Start is called before the first frame update
    void Start()
    {
        healing = false;
        health = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healing == true) { 
           if (health.BarFill < 50)
            {
                if (HealDelay < Time.time)
                {

                    HealDelay = Delay + Time.time;
                    health.BarFill += 2;
                }


            } 
        }
        else
        {

        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {

            healing = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {
            healing = false;
        }
    }
}
