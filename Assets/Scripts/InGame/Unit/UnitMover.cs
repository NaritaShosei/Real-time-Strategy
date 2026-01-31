using UnityEngine;
using UnityEngine.AI;

public class UnitMover
{
    public UnitMover(NavMeshAgent agent)
    {
        _agent = agent;
    }

    public void MoveTo(Vector3 pos)
    {
        _agent.SetDestination(pos);
    }

    private NavMeshAgent _agent;
}
