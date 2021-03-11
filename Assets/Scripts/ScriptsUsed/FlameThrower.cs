using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public GameObject Flames;
    public bool FlameCheck; 
    public GameObject Whichplayer;
    Movement WhichPlayer_script;
    bool Switch1;
    
    // Start is called before the first frame update
    void Start()
    {
        Flames.SetActive(false);
        WhichPlayer_script = Whichplayer.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        Switch1 = WhichPlayer_script.Switch;
        if (Switch1 == false) {
            if (Input.GetKeyUp("e"))
            {
                if (FlameCheck == false)
                {
                    Debug.Log("Change");
                    Flames.SetActive(true);
                    FlameCheck = true;
                }
                else if (FlameCheck == true)
                {
                    Debug.Log("Change");
                    Flames.SetActive(false);
                    FlameCheck = false;
                }

            }
        }
        /////////////////////////////// FLAME THROWER /////////////////////////////////////////
        
        //////////////////////////////////////MELT ICE////////////////////////
        



        ///////////////////////////////////KILLING ENEMIES////////////////////////a


        /////////////////////////////////////FORGE ITEMS///////////////////////////
    }
}
