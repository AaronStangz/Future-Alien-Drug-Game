using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npc : MonoBehaviour
{
    [SerializeField] private LayerMask whatIsPlayer;
    public Transform player;

    private NavMeshAgent Agent;

    public List<Transform> wayPoint;
    public int currentWaypointIndex = 0;


    public float byPlayerRange, AwayPlayerRange;
    public bool byPlayer, awayPlayer;

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        Agent.SetDestination(wayPoint[currentWaypointIndex].position);
    }

    void Start()
    {

    }

    void Update()
    {
        byPlayer = Physics.CheckSphere(transform.position, byPlayerRange, whatIsPlayer);
        awayPlayer = Physics.CheckSphere(transform.position, AwayPlayerRange, whatIsPlayer);

        if (byPlayer && awayPlayer) { ByPlayer(); }
        if (!byPlayer && awayPlayer) { AwayPlayer(); }
    }
    public void ByPlayer()
    {
        print("sss");
        gameObject.GetComponent<NavMeshAgent>().isStopped = true;
    }

    public void AwayPlayer()
    {
        print("AAA");
        gameObject.GetComponent<NavMeshAgent>().isStopped = false;

        if (wayPoint.Count == 0)
        {

            return;
        }


        float distanceToWaypoint = Vector3.Distance(wayPoint[currentWaypointIndex].position, transform.position);

        if (distanceToWaypoint <= 8)
        {

            currentWaypointIndex = (currentWaypointIndex + 1) % wayPoint.Count;
        }

        Agent.SetDestination(wayPoint[currentWaypointIndex].position);
    }
}
