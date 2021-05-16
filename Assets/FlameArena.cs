using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameArena : MonoBehaviour
{
    BossMechanics BossMec;
    public float Delay;
    public float fireDelay = 2f;
    PlayerHealth Health1;
    public bool attackingFlames;
    // Start is called before the first frame update
    void Start()
    {
        BossMec = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossMechanics>();
        Health1 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attackingFlames == true)
        {
            if ( Time.time > Delay)
            {
                Delay = Time.time + fireDelay;
                Health1.BarFill-= 5;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Flames") )
        {
            attackingFlames = true;
         
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Flames"))
        {
            attackingFlames = false;

        }
    }
}
