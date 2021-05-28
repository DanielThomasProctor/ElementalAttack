using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        if(BarFill <=0){
            SceneManager.LoadScene("Defeat");
        }

        Border.SetBar(BarFill);
    }
}
