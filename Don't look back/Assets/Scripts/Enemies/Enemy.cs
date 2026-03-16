using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    [SerializeField] float waitTimeOnWayPoint = 1f;
    [SerializeField] Path path;

    NavMeshAgent agent;

    float time = 0f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        agent.destination = path.GetCurrentWayPoint();
    }

    private void Update()
    {
        if (agent.remainingDistance <= 0.1f)
        {
            time += Time.deltaTime;
            if (time > waitTimeOnWayPoint)
            {
                time = 0f;
                agent.destination = path.GetNextWaypoint();
            }
        }
    }
}
