using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMechanics : MonoBehaviour
{
    public bool Bossfight;
    
    /// /////////////////LeftDragon - 1////////////////////
    
    public GameObject DragonLeft;//1
    public GameObject DragonLeftStatue1;//1
    public GameObject DragonLeftStatue2;//1
    public GameObject DragonLeftFire;//1
    /// /////////////////RightDragon - 3////////////////////
    public GameObject DragonRight;//2
    public GameObject DragonRightStatue1;//1
    public GameObject DragonRightStatue2;//1
    public GameObject DragonRightFire;//1
    /// /////////////////MiddleDragon - 2////////////////////
    public GameObject DragonMiddle;//3
    public GameObject DragonMiddleStatue1;//1
    public GameObject DragonMiddleStatue2;//1
    public GameObject DragonMiddleFire;//1
    public int Dragonnumber = 1;
    /// ///////////////////////////////////////////////////////
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    /// ///////////////////////////////////////////////////////
    public GameObject shotClass;
    public float speed;
    float DragonDelay;
    public float Delay;
    FlameArena Flamesss;
    // Start is called before the first frame update
    void Start()
    {
        Delay = 21f;
        speed = 1000f;
        Bossfight = false;
        DragonLeft.SetActive(false);
        DragonLeftStatue1.SetActive(false);
        DragonLeftStatue2.SetActive(false);
        DragonLeftFire.SetActive(false);

        DragonRight.SetActive(false);
        DragonRightFire.SetActive(false);
        DragonRightStatue1.SetActive(false);
        DragonRightStatue2.SetActive(false);
      
        DragonMiddleFire.SetActive(false);
        DragonMiddleStatue1.SetActive(false);
        DragonMiddleStatue2.SetActive(false);
        DragonMiddle.SetActive(false);
        //Move = GameObject.FindGameObjectWithTag("BossFightTrigger").GetComponent<>();
        trigger1.SetActive(false);
        trigger2.SetActive(false);
        trigger3.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Bossfight == true)
        {
            if (DragonDelay < Time.time)
            {
              
                DragonDelay = Delay + Time.time;
                if (Dragonnumber == 1)
                {
                    DragonLeft.SetActive(true);
                    StartCoroutine(DragonLeft1(1.0F));
                }
                else if (Dragonnumber == 2)
                {
                    DragonRight.SetActive(true);
                    StartCoroutine(DragonRight2(1.0F));
                }
                else if (Dragonnumber == 3)
                {
                    DragonMiddle.SetActive(true);
                    StartCoroutine(DragonMiddle3(1.0F));
                }

            }
        }
    }
    IEnumerator DragonLeft1(float DragonLeft11)
    {
        trigger1.SetActive(false);
        trigger2.SetActive(false);
        trigger3.SetActive(false);
        yield return new WaitForSeconds(2);
        DragonLeftStatue1.SetActive(true);
        DragonLeftStatue2.SetActive(true);
        yield return new WaitForSeconds(4);
        DragonLeftFire.SetActive(true);
        trigger1.SetActive(true);
        Flamesss = GameObject.FindGameObjectWithTag("Triggers").GetComponent<FlameArena>();
        yield return new WaitForSeconds(4);
        Flamesss.attackingFlames = false;
        DragonLeftFire.SetActive(false);
        DragonLeftStatue1.SetActive(false);
        DragonLeftStatue2.SetActive(false);
        trigger1.SetActive(false);
        yield return new WaitForSeconds(10);
        DragonLeft.SetActive(false);
        Debug.Log("Time to switch");
        Dragonnumber = 2;
    }
    IEnumerator DragonRight2(float DragonRight11)
    {
        trigger1.SetActive(false);
        trigger2.SetActive(false);
        trigger3.SetActive(false);
        yield return new WaitForSeconds(2);
        DragonRightStatue1.SetActive(true);
        DragonRightStatue2.SetActive(true);
        yield return new WaitForSeconds(4);
      
        DragonRightFire.SetActive(true);
        trigger2.SetActive(true);
        Flamesss = GameObject.FindGameObjectWithTag("Triggers").GetComponent<FlameArena>();
        yield return new WaitForSeconds(4);
        Flamesss.attackingFlames = false;
        DragonRightFire.SetActive(false);
        DragonRightStatue1.SetActive(false);
        DragonRightStatue2.SetActive(false);
        trigger2.SetActive(false);
        yield return new WaitForSeconds(10);
        DragonRight.SetActive(false);
        Debug.Log("Time to switch");
        Dragonnumber = 3;
    }
    IEnumerator DragonMiddle3(float DragonMiddle11)
    {
        trigger1.SetActive(false);
        trigger2.SetActive(false);
        trigger3.SetActive(false);
        yield return new WaitForSeconds(2);
        DragonMiddleStatue1.SetActive(true);
        DragonMiddleStatue2.SetActive(true);
        yield return new WaitForSeconds(4);

        DragonMiddleFire.SetActive(true);
        trigger3.SetActive(true);
        Flamesss = GameObject.FindGameObjectWithTag("Triggers").GetComponent<FlameArena>();
        yield return new WaitForSeconds(4);
        Flamesss.attackingFlames = false;
        DragonMiddleFire.SetActive(false);
        DragonMiddleStatue1.SetActive(false);
        DragonMiddleStatue2.SetActive(false);
        trigger3.SetActive(false);
        yield return new WaitForSeconds(10);
        DragonMiddle.SetActive(false);
        Debug.Log("Time to switch");
        Dragonnumber = 1;
    }
}
