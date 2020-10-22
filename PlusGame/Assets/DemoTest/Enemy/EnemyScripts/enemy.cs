using UnityEngine;

public class enemy : MonoBehaviour, IDamageable
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

    public void TakeDamage()
    {
        Hp -= 30;
    }
}
