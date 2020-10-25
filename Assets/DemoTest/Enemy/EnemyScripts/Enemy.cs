using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHP;
    [SerializeField] private int _hp;

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
        Destroy(gameObject);
    }
}
