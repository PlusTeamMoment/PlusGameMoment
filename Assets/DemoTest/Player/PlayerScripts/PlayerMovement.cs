using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] private INullablePlayerControls playerControls;
    private Rigidbody2D rigidbody;
    private Animator animator;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        if (GetComponent<PlayerControls>() == null)
            playerControls = new NullPlayerControls();
        else
            playerControls = GetComponent<PlayerControls>();

        animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        Vector2 movement = new Vector2(playerControls.Horizontal, playerControls.Vertical);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        rigidbody.velocity = movement.normalized * movementSpeed * Time.fixedDeltaTime;

    }

    public bool FacingLeft()
    {
        return rigidbody.velocity.x < 0;
    }
    public bool FacingRight()
    {
        return rigidbody.velocity.x > 0;
    }
    public bool FacingUp()
    {
        return rigidbody.velocity.y > 0;
    }
    public bool FacingDown()
    {
        return rigidbody.velocity.y < 0;
    }
}
