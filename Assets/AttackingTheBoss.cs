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

         
            Debug.Log("Projectile collided");


               

                        if (health.BarFill <= 0)
                        {

                            health.BarFill = 0;
                            Debug.Log("Dead");


               
                        }
                        else
                        {
                            health.BarFill -= 5;

                            Debug.Log("-5");
                        }
            health.Border.SetBar(health.BarFill);
            Destroy(this.gameObject);
                    
                        
            }


        }
        IEnumerator Wait(float Wait1)
        {
            yield return new WaitForSeconds(2);
            ;
        }



















    }

