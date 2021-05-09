using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULT : MonoBehaviour
{
    public GameObject Ult;
    public Transform player;
    public Vector3 playerposition;
    FeatherTally Feather;
    // Start is called before the first frame update
    void Start()
    {
       // player = GameObject.FindGameObjectWithTag("Player").transform;
        Feather = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<FeatherTally>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Feather.Percent == 100) {
            Debug.Log("Greater than 100");
           // playerposition = new Vector3(player.position.x + 140, player.position.y + -3, player.position.z + 140);
            Instantiate(Ult, (player.transform.position + player.transform.forward*2), (player.transform.rotation ));
            Debug.Log("Made object");
            Feather.FeathersUsed = 10;
            Debug.Log("minus 10");
        } 
    }
}
