using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAgent : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] List<Transform> waypoints;
    private int currentWayPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(waypoints[currentWayPoint].position);   
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 0.1f)
        {
            currentWayPoint++;

            if (currentWayPoint >= waypoints.Count)
            {
                currentWayPoint = 0;

            }
        }
        agent.SetDestination(waypoints[currentWayPoint].position);
    }

}
