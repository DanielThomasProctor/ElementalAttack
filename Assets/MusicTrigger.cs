using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{ BossMechanics health;
    AudioSource audioData;
    public bool a = true;
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        if (a==true) {
            if (health.Bossfight == true)
            {

                audioData.Pause();
                a = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames" )
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(10);
            Debug.Log("started");

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flames")
        {
            audioData.Pause();

        }
    }



}
