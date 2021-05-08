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


    
    void Start()
    {


        enemy = GetComponent<NavMeshAgent>();

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
            
            Vector3 newPos = transform.position -  dirToPlayer;
            ChaseTrigger.SetActive(true);
            enemy.SetDestination(newPos);
        }
        else if ((distance < 25 &&Mathf.Abs(angle1)<90 && Mathf.Abs(angle1) < 270)|| distance < 15)
        {
             
                Vector3 newPos = transform.position -  dirToPlayer2;
            ChaseTrigger.SetActive(true);
            enemy.SetDestination(newPos);
           


            }
        else if ((distance2 < 25 && Mathf.Abs(angle2) < 90 && Mathf.Abs(angle2) < 270) || distance2 < 15)
        {

            Vector3 newPos = transform.position - dirToPlayer2;
            ChaseTrigger.SetActive(true);
            enemy.SetDestination(newPos);

        }
        else if (!enemy.pathPending && enemy.remainingDistance < 0.5f && ChaseTrigger== true)
        {

        }
           

        else if (!enemy.pathPending && enemy.remainingDistance < 3f)
            NextLocation();
    }
}
