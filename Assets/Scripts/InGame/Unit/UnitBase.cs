using UnityEngine;
using UnityEngine.AI;

public class UnitBase : MonoBehaviour, IHealth
{
    public void TakeDamage(float damage)
    {
        _healthSystem.TakeDamage(damage);
    }

    public void ChangeTarget(GameObject nextTarget)
    {
        _target = nextTarget;
    }

    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] GameObject _target;
    private UnitMover _mover;
    private UnitStats _stats;
    private HealthSystem _healthSystem;

    private void Start()
    {
        _stats = new UnitStats();
        _mover = new UnitMover(_agent, _stats);
        _healthSystem = new HealthSystem(_stats);
        _healthSystem.OnDead += OnDeath;
    }

    private void Update()
    {
        _mover.MoveTo(_target.transform.position);
    }

    private void OnDeath()
    {
        Debug.Log("死亡");
    }
}
