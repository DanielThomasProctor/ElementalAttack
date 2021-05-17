using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiKaboom : MonoBehaviour
{
    PlayerHealth PlayerHealth1;
    public bool KillZone1;
    public bool KillZone2;
    public bool KillZone3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth1 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
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
        Debug.Log("waiting");
        yield return new WaitForSeconds(4);
        if (KillZone1 == true)
        {
            PlayerHealth1.BarFill -= 15;
        }
        else if (KillZone2 == true)
        {
            PlayerHealth1.BarFill -= 10;
        }
        else if (KillZone3 == true)
        {
            PlayerHealth1.BarFill -= 5;
        }
        KillZone1 = false;
        KillZone2 = false;
        KillZone3 = false;
        Debug.Log("waited");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
