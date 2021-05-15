using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideBullet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {

            Destroy(this.gameObject);

        }
    }
}
