using System;
using UnityEngine;

public class HealthSystem
{
    public event Action OnDead;
    public event Action<float, float> OnHealthChange;

    public HealthSystem(UnitStats stats)
    {
        _maxHealth = stats.MaxHP;
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        OnHealthChange?.Invoke(_currentHealth, _maxHealth);

        if (_currentHealth <= 0)
        {
            OnDead?.Invoke();
        }
    }

    private float _currentHealth;
    private float _maxHealth;
}
