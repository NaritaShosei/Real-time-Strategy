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
        if (Vector3.Distance(_lastTargetPos, pos) > 1.0f)
        {
            _lastTargetPos = pos;
            _agent.SetDestination(_lastTargetPos);
        }
    }

    private NavMeshAgent _agent;
    private Vector3 _lastTargetPos;
}
