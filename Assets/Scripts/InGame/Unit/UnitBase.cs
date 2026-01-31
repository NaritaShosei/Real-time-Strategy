using UnityEngine;
using UnityEngine.AI;

public class UnitBase : MonoBehaviour, IHealth
{
    public void TakeDamage(float damage)
    {
        _healthSystem.TakeDamage(damage);
    }

    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] GameObject gameManager;
    private UnitMover _mover;
    private HealthSystem _healthSystem;

    private void Start()
    {
        _mover = new UnitMover(_agent);
        _healthSystem = new HealthSystem(100);
        _healthSystem.OnDead += OnDeath;
    }

    private void Update()
    {
        _mover.MoveTo(gameManager.transform.position);
    }

    private void OnDeath()
    {
        Debug.Log("死亡");
    }
}
