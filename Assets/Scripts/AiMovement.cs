using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AiMovement : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player2;

    public Transform[] Loctations;
    private int distanceFromLoctaion = 0;
    private NavMeshAgent enemy;
    public GameObject ChaseTrigger;
    PlayerHealth PlayerHealth1;
    public bool a;

    void Start()
    {

        PlayerHealth1 = GameObject.FindGameObjectWithTag("Mechanics").GetComponent<PlayerHealth>();
        enemy = GetComponent<NavMeshAgent>();
        a = false;
        //allows continuus movement
        enemy.autoBraking = false;
        ChaseTrigger.SetActive(false);
        NextLocation();
    }


    void NextLocation()
    {
        if (Loctations.Length == 0)
            return;


        enemy.destination = Loctations[distanceFromLoctaion].position;


        distanceFromLoctaion = (distanceFromLoctaion + 1) % Loctations.Length;
    }


    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        float distance2 = Vector3.Distance(transform.position, Player2.transform.position);
        Vector3 dirToPlayer = transform.position - Player.transform.position;
        float angle1 = Vector3.Angle(transform.forward, dirToPlayer);
        Vector3 dirToPlayer2 = transform.position - Player2.transform.position;
        float angle2 = Vector3.Angle(transform.forward, dirToPlayer2);
        if (distance < 25 && Mathf.Abs(angle1) < 90 && Mathf.Abs(angle1) < 270)
        {

            Vector3 newPos = transform.position - dirToPlayer;
            //ChaseTrigger.SetActive(true);
            enemy.SetDestination(newPos);
        }
        else if ((distance < 25 && Mathf.Abs(angle1) < 90 && Mathf.Abs(angle1) < 270) || distance < 20)
        {

            Vector3 newPos = transform.position - dirToPlayer2;
           // ChaseTrigger.SetActive(true);
           // a = true;
            enemy.SetDestination(newPos);



        }
        else if ((distance2 < 25 && Mathf.Abs(angle2) < 90 && Mathf.Abs(angle2) < 270) || distance2 < 20)
        {
            
             Vector3 newPos = transform.position - dirToPlayer2;
           // ChaseTrigger.SetActive(true);
           // a = true;
            enemy.SetDestination(newPos);
            
            

        }
        else if (!enemy.pathPending && enemy.remainingDistance < 10f )
        {
            //start explosion
            Debug.Log("lets expload");
           // Debug.Log(enemy.remainingDistance.ToString());
           // StartCoroutine(Explosion12(1.0F));

        }


        else if (!enemy.pathPending && enemy.remainingDistance < 15f )
            NextLocation();
    }
    IEnumerator Explosion123(float Explosion1)
    {
        Debug.Log("waiting");
        yield return new WaitForSeconds(2);
        Debug.Log("waited");
        if (enemy.remainingDistance < 10f)
        {
            PlayerHealth1.BarFill -= 25;
        }
        else if(enemy.remainingDistance < 15f)
        {
            PlayerHealth1.BarFill -= 10;
        }
        else if (enemy.remainingDistance < 20f)
        {
            PlayerHealth1.BarFill -= 5;
        }
        else
        {

        }
        a = false;
        Destroy(this.gameObject);
    }
}
