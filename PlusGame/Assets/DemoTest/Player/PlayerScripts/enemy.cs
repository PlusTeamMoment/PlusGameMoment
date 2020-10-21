using UnityEngine;

public class enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHP;
    [SerializeField] private int _hp;
    public int Hp
    {
        get => _hp;
        private set
        {
            if (value > maxHP) _hp = maxHP;
            if (value <= 0) _hp = 1;
        }
    }

    void OnEnable()
    {
        _hp = maxHP;
    }

    public void TakeDamage()
    {
        Hp -= 30;
    }
}
