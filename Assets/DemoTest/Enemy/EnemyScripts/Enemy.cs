using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHP;
    [SerializeField] private int _hp;
    private Spawner spawner;

    private void Update()
    {
        spawner = FindObjectOfType<Spawner>();
    }

    public int Hp
    {
        get => _hp;
        private set => _hp = Mathf.Clamp(value, 0, maxHP);
    }

    void OnEnable()
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

    private void Die()
    {
        spawner.activeEnemies.Remove(this);
        Destroy(gameObject);
    }
}
