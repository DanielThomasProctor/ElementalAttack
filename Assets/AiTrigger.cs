using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiTrigger : MonoBehaviour
{
    public bool a;
    AiMovement Trig;
    // Start is called before the first frame update
    void Start()
    {
        Trig = GameObject.FindGameObjectWithTag("Enemy").GetComponent<AiMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Water")
        {
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Flames"|| other.gameObject.tag == "Water")
        {
           Debug.Log("enemy trigger deactivated");
            Trig.ChaseTrigger.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
