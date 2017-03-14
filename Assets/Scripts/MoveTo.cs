using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform goal;
    public static MoveTo Instance { get; private set; }

    void Start()
    {
        Instance = this;

        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    public void ChangeTarget(Transform newTarget)
    {
        agent.destination = newTarget.position;
    }
}