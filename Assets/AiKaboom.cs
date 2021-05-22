using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiKaboom : MonoBehaviour
{
    PlayerHealth PlayerHealth1;
    
    BolwingUpThePlayer PlayerHealth12;
    public GameObject flames;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth1 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
        PlayerHealth12 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BolwingUpThePlayer>();
        flames.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames"|| other.gameObject.tag == "Water")
        {

            StartCoroutine(Explosion12(1.0F));

        }
    }
    IEnumerator Explosion12(float Explosion1)
    {
        flames.SetActive(true);
        Debug.Log("waiting");
        yield return new WaitForSeconds(4);
        Debug.Log("Damage");
        if (PlayerHealth12.KillZone1 == true)
        {
            Debug.Log("killz1");
            PlayerHealth1.BarFill -= 15;
        }
        else {
            if (PlayerHealth12.KillZone2 == true)
            {
                Debug.Log("killz2");
                PlayerHealth1.BarFill -= 10;
            }
            else {
                 if (PlayerHealth12.KillZone3 == true)
                {
                    Debug.Log("killz3");
                    PlayerHealth1.BarFill -= 5;
                }
                else
                {

                }
            }
        }
       
        
        PlayerHealth12.KillZone1 = false;
        PlayerHealth12.KillZone2 = false;
        PlayerHealth12.KillZone3 = false;
        Debug.Log("waited");
        
        Destroy(this.gameObject);
    }
}
