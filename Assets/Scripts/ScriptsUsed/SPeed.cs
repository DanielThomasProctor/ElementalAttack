using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPeed : MonoBehaviour
{
    public GameObject Whichplayer;
    Movement WhichPlayer_script;

    public GameObject in_air;


    public bool Switch1;
    // Start is called before the first frame update
    void Start()
    {
        WhichPlayer_script = Whichplayer.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        Switch1 = WhichPlayer_script.Switch;
        if (Switch1 == true)
        {

        }
    }
}
