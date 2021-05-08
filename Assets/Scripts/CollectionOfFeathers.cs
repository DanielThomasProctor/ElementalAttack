using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionOfFeathers : MonoBehaviour
{
    FeatherTally Feather;
    // Start is called before the first frame update
    void Start()
    {
       Feather = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<FeatherTally>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter(Collider other)
    {




        if (other.CompareTag("Water")|| other.CompareTag("Flames"))
        {
            Debug.Log("");
            Feather.Feathers += 1;
            Destroy(this.gameObject);
        }



    }
}
