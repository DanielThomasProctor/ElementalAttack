using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Boss : MonoBehaviour
{
    public GameObject BossStartPos;
    public GameObject Player;
    FeatherTally Feather;
    BossMechanics BossMec;
    public Text speach;
    public GameObject BossHealthBar;
    string phrases;
    SpawningAmmo Spawning;
    // Start is called before the first frame update
    void Start()
    {
        Feather = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<FeatherTally>();
        BossMec = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<BossMechanics>();
        Spawning = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<SpawningAmmo>();
        BossHealthBar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flames" || other.gameObject.tag == "Water")
        {

            if (Feather.Feathers <20)
            {
                speach.text = ("I can not grant you passage until you have collected enough feathers of fate to grant you safe passage").ToString();
            }
            else if (Feather.Feathers >= 20)
            {
                speach.text = ("I will let you both in but you must defeat the possessed dragon to save Abrugog. Water Girl take the Ballista and Fire boy collect the arrows doging the flames.").ToString();
                BossHealthBar.SetActive(true);
                //move player into boss arena
                Spawning.isActive = true;
                Player.transform.position = BossStartPos.transform.position;
                //trigger boss fight
                BossMec.Bossfight = true;
            }
        }
    }
}
