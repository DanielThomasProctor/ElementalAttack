using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{

    public int MinBar = 0;
    public int MaxBar = 50;
    public int BarFill;
    public SettingPlayerHealth Border;

    public int Health;

    void Start()
    {
        BarFill = 50;

    }

    // Update is called once per frame
    void Update()
    {


        Border.SetBar(BarFill);
    }
}
