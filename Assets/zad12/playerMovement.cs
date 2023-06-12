using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerMovement : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform targetPosition;
    void Update()
    {
        navMeshAgent.SetDestination(targetPosition.position);
    }
}
