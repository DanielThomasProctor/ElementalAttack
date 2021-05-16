using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingPlayerHealth : MonoBehaviour
{
    public Slider Bar;

    //setting values for  bar

    public void SetBarMin(int BarPos)
    {
        Bar.minValue = BarPos;
        Bar.value = BarPos;
    }
    public void SetBarMax(int BarPos)
    {
        Bar.maxValue = BarPos;
        Bar.value = BarPos;
    }

    public void SetBar(int BarPos)
    {
        Bar.value = BarPos;
    }
}
