using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] protected int maxHP;
    [SerializeField] protected int _hp;
    protected Spawner spawner;
    [SerializeField] protected string essenceName;
    [SerializeField] protected int essenceFillAmount;
    public static Action<string, int> onKill;

    protected void Update()
    {
        spawner = FindObjectOfType<Spawner>();
    }

    public int Hp
    {
        get => _hp;
        private set => _hp = Mathf.Clamp(value, 0, maxHP);
    }

    protected void OnEnable()
    {
        _hp = maxHP;
    }

    public void TakeDamage(int damage)
    {
        Hp -= damage;
        if (_hp <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        onKill?.Invoke(essenceName, essenceFillAmount);
        Destroy(gameObject);

    }

    protected void OnDestroy()
    {
        spawner?.activeEnemies.Remove(this);

    }
}
