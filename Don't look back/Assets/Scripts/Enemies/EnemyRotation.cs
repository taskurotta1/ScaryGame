using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class EnemyRotation : MonoBehaviour
{
    public GameObject NavMeshAgent;
    public float rotationX;
    public float rotationY;
    public float enemyGroundedHeight = 0.5f;

    protected void Update()
    {
        NavMeshAgent.transform.rotation = Quaternion.Euler(rotationX, NavMeshAgent.transform.rotation.eulerAngles.y, NavMeshAgent.transform.rotation.eulerAngles.z);
        NavMeshAgent.transform.rotation = Quaternion.Euler(NavMeshAgent.transform.rotation.eulerAngles.x, rotationY, NavMeshAgent.transform.rotation.eulerAngles.z);
        NavMeshAgent.transform.position = new Vector3(NavMeshAgent.transform.position.x, enemyGroundedHeight, NavMeshAgent.transform.position.z);
    }
}
