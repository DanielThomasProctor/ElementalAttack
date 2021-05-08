using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FeatherTally : MonoBehaviour
{
    public int Feathers;
    public int FeathersUsed;
    public int Percent;
    public Text text;

    /// ////////////////////////////ULTIMATE BAR SECTIONS/////////////////////
    public GameObject Segment1;
    public GameObject Segment2;
    public GameObject Segment3;
    public GameObject Segment4;
    public GameObject Segment5;
    public GameObject Segment6;
    public GameObject Segment7;
    public GameObject Segment8;
    public GameObject Segment9;
    public GameObject Segment10;






    // Start is called before the first frame update
    void Start()
    {
         Feathers =0;
        FeathersUsed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Percent = (Feathers - FeathersUsed) * 10;
        text.text = (Percent.ToString() + "%");
        if (Percent == 0)
        {
            Segment1.SetActive(false);
            Segment2.SetActive(false);
            Segment3.SetActive(false);
            Segment4.SetActive(false);
            Segment5.SetActive(false);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 10)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(false);
            Segment3.SetActive(false);
            Segment4.SetActive(false);
            Segment5.SetActive(false);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 20)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(false);
            Segment4.SetActive(false);
            Segment5.SetActive(false);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 30)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(false);
            Segment5.SetActive(false);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 40)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(false);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 50)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(false);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 60)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(true);
            Segment7.SetActive(false);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 70)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(true);
            Segment7.SetActive(true);
            Segment8.SetActive(false);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 80)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(true);
            Segment7.SetActive(true);
            Segment8.SetActive(true);
            Segment9.SetActive(false);
            Segment10.SetActive(false);
        }
        else if (Percent == 90)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(true);
            Segment7.SetActive(true);
            Segment8.SetActive(true);
            Segment9.SetActive(true);
            Segment10.SetActive(false);
        }
        else if (Percent >= 100)
        {
            Segment1.SetActive(true);
            Segment2.SetActive(true);
            Segment3.SetActive(true);
            Segment4.SetActive(true);
            Segment5.SetActive(true);
            Segment6.SetActive(true);
            Segment7.SetActive(true);
            Segment8.SetActive(true);
            Segment9.SetActive(true);
            Segment10.SetActive(true);

        }
    }
}
