using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill : MonoBehaviour
{
    public GameObject Cube;
    public int countdown = 0;
    public float SwitchDelay;
    public float TimeToSwitch = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "Flames")
        {
            StartCoroutine(MeltTime(20000.0F));






        }

        IEnumerator MeltTime(float MeltTime1)
        {
            yield return new WaitForSeconds(3);

            Destroy(gameObject);

            Debug.Log("test");


        }
    }
    void OnCollisionExit(Collision collision)
    {


        if (collision.gameObject.name == "Flames")
        {
            StartCoroutine(MeltTime(20000.0F));






        }

        IEnumerator MeltTime(float MeltTime1)
        {
            yield return new WaitForSeconds(3);

            Destroy(gameObject);

            Debug.Log("test");


        }
    }
}
