using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULT : MonoBehaviour
{
    public GameObject Ult;
    public Transform player;
    public Vector3 playerposition;
    FeatherTally Feather;
    Movement Move;
    public GameObject Ult2;
    public Transform player2;
    // Start is called before the first frame update
    void Start()
    {
       
        Feather = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<FeatherTally>();
        Move= GameObject.FindGameObjectWithTag("PlayerMovement").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Feather.Percent >= 100) {
            if (Input.GetKey("g") && Move.Switch == true ) {
                Debug.Log("Greater than 100");
               
                Instantiate(Ult2, (player2.transform.position + player2.transform.forward * 8 - player2.transform.up), (player2.transform.rotation * Quaternion.Euler(0f, 180f, 0f)));
                Debug.Log("Made object");
                Feather.FeathersUsed = 10;
                Debug.Log("minus 10");
            }
            else if(Input.GetKey("g") && Move.Switch == false)
            {
                
                    Debug.Log("Greater than 100");
                   
                    Instantiate(Ult, (player.transform.position + player.transform.forward * 8 - player.transform.up), (player.transform.rotation * Quaternion.Euler(0f, 180f, 0f)));
                    Debug.Log("Made object");
                    Feather.FeathersUsed = 10;
                    Debug.Log("minus 10");
                 
            }
        } 
    }
}
