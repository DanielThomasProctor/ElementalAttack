using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingTheBoss : MonoBehaviour
{
    BossHealth health;
  
  

    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossHealth>();

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boss")
        {

         
            Debug.Log("Prijectile collided");


               

                        if (health.BarFill <= 0)
                        {

                            health.BarFill = 0;
                            Debug.Log("Dead");


                //// end cutscene
                        }
                        else
                        {
                            health.BarFill -= 5;

                            Debug.Log("TickDown");
                        }


                        health.Border.SetBar(health.BarFill);
                        
            }


        }
        IEnumerator Wait(float Wait1)
        {
            yield return new WaitForSeconds(2);
            ;
        }



















    }

