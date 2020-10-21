using UnityEngine;

public class DamageCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var damageable = collision.gameObject.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage();
        }
    }
}
