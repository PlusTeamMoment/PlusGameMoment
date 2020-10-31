using UnityEngine;

public class DamageCheck : MonoBehaviour
{
    [SerializeField] int attackDamage;
    [SerializeField] private GameObject player_main;
    [SerializeField] private float offset;
    [SerializeField] private PlayerMovement playerMovement;

    private void Start()
    {
        HitboxRepositionUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var damageable = collision.gameObject.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.TakeDamage(attackDamage);
        }
    }

    private void Update()
    {

        if (playerMovement.FacingRight())
        {
            HitboxRepositionRight();
        }
        else if (playerMovement.FacingLeft())
        {
            HitboxRepositionLeft();
        }
        else if (playerMovement.FacingUp())
        {
            HitboxRepositionUp();
        }
        else if (playerMovement.FacingDown())
        {
            HitboxRepositionDown();
        }
    }

    private void HitboxRepositionDown()
    {
        transform.position = new Vector3(player_main.transform.position.x, player_main.transform.position.y - offset, player_main.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void HitboxRepositionUp()
    {
        transform.position = new Vector3(player_main.transform.position.x, player_main.transform.position.y + offset, player_main.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void HitboxRepositionLeft()
    {
        transform.position = new Vector3(player_main.transform.position.x - offset, player_main.transform.position.y, player_main.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void HitboxRepositionRight()
    {
        transform.position = new Vector3(player_main.transform.position.x + offset, player_main.transform.position.y, player_main.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }
}
