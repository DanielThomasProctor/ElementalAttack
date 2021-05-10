using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningDragons : MonoBehaviour
{
    
    BossMechanics BossMec;
    // Start is called before the first frame update
    void Start()
    {
        BossMec = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {




        if (other.CompareTag("Water") || other.CompareTag("Flames"))
        {
            BossMec.Bossfight = true;
        }



    }
}
