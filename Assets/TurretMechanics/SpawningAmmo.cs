using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAmmo : MonoBehaviour
{
    public Transform[] Loctations;

    
    public GameObject Location1;
    public GameObject Location2;
    public GameObject Location3;
    public GameObject Location4;
    public GameObject Location5;
    public GameObject Location6;
    public GameObject Location7;
    public GameObject Location8;
    public GameObject Location9;
    public GameObject Location10;
    public GameObject Location11;
    public GameObject Location12;
    public int number;
    public int a;
    public bool isActive;
    float fireDelay = 10f;
    public GameObject ArrowDrop;
    float Delay;
    void Start()
    {
        number = Random.Range(1, 13);
        isActive = false;

    }



    void Update()
    {
        if (isActive == true)
        {
            if (Time.time > Delay)
            {
                number = Random.Range(1, 13);
                Debug.Log(number);
                Delay = Time.time + fireDelay;
                if (number == 1)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location1.transform.position, transform.rotation);

                }
                else if (number == 2)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location2.transform.position, transform.rotation);
                }
                else if (number == 3)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location3.transform.position, transform.rotation);
                }
                else if (number == 4)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location4.transform.position, transform.rotation);
                }
                else if (number == 5)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location5.transform.position, transform.rotation);
                }
                else if (number == 6)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location6.transform.position, transform.rotation);
                }
                else if (number == 7)
                {
                    GameObject shotInstance = Instantiate(ArrowDrop, Location7.transform.position, transform.rotation);
                }
                else if (number == 8)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location8.transform.position, transform.rotation);
                }
                else if (number == 9)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location9.transform.position, transform.rotation);
                }
                else if (number == 10)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location10.transform.position, transform.rotation);
                }
                else if (number == 11)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location11.transform.position, transform.rotation);
                }
                else if (number == 12)
                {

                    GameObject shotInstance = Instantiate(ArrowDrop, Location12.transform.position, transform.rotation);
                }
            }
        }
    }
}
