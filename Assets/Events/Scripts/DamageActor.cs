using System;
using UnityEngine;

public class DamageActor : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;

    public event Action<float> OnDamage;
    public event Action OnDeath;
    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth = Mathf.Max(0f, currentHealth - damage);
        OnDamage?.Invoke(damage);
        if (currentHealth == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        OnDeath?.Invoke();
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }
}
