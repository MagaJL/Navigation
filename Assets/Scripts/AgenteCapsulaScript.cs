using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgenteCapsulaScript : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    public Transform targetTR;
    [SerializeField] Animator anim;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();

    }

    private void Start()
    {
        
    }

    void Update()
    {
        agent.destination = targetTR.position;
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
}
