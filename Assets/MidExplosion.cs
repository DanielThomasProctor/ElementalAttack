using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidExplosion : MonoBehaviour
{
    BolwingUpThePlayer Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BolwingUpThePlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {

            Enemy.KillZone2 = true;

        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {

            Enemy.KillZone2 = false;
        }
    }
}
