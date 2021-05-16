using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoForTurret : MonoBehaviour
{
    public Text text;
    public int ammo=0;
    public GameObject OutOfAmmo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ammo.ToString();
        if (ammo >0) {

            OutOfAmmo.SetActive(false);
        }
        else
        {
            OutOfAmmo.SetActive(true);
        }
    }
   
}
