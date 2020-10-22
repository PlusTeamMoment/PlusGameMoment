using UnityEngine;

public class DamageCheck : MonoBehaviour
{
    [SerializeField] private GameObject player_main;
    [SerializeField] private float offset;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var damageable = collision.gameObject.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage();
        }
    }

    private void Update()
    {
        this.transform.position = new Vector3(player_main.transform.position.x, player_main.transform.position.y + offset, player_main.transform.position.z);
    }
}
