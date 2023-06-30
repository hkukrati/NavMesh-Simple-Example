using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowerAgent : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform player;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(player.position);   
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
