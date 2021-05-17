﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerExplosion : MonoBehaviour
{
    AiKaboom Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AiKaboom>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {

            Enemy.KillZone1 = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water") { 

            Enemy.KillZone1 = false;
        }
    }
}
