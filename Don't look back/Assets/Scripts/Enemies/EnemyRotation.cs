using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class EnemyRotation : MonoBehaviour
{
    public GameObject NavMeshAgent;
    public float rotationX;

    protected void Update()
    {
        NavMeshAgent.transform.rotation = Quaternion.Euler(rotationX, NavMeshAgent.transform.rotation.eulerAngles.y, NavMeshAgent.transform.rotation.eulerAngles.z);
    }
}
