using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBurn : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player2;
    public GameObject TP;
    PlayerHealth PlayerHealth1;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth1 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Flames")
        {
            PlayerHealth1.BarFill -= 25;
            
            Player.transform.position = TP.transform.position;
            Debug.Log("TP");
        }
        if (other.gameObject.tag == "Water")
        {
            PlayerHealth1.BarFill -= 25;

            Player2.transform.position = TP.transform.position;
            Debug.Log("TP");
        }
    }
}
