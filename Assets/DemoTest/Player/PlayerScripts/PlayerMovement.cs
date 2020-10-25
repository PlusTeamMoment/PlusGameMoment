using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementDivisionValue;
    [SerializeField] private INullablePlayerControls playerControls;
    private Rigidbody2D player_rb;
    private Direction facingDirection;
    public Direction FacingDirection { get => facingDirection; private set=> facingDirection = value; }
    

    void Awake()
    {
        player_rb = GetComponent<Rigidbody2D>();
        if (GetComponent<PlayerControls>() == null)
            playerControls = new NullPlayerControls();
        else
            playerControls = GetComponent<PlayerControls>();
    }

    private void Start()
    {
        movementSpeed /= movementDivisionValue;
    }

    void FixedUpdate()
    {
        
        player_rb.velocity = new Vector2(playerControls.Horizontal * movementSpeed, playerControls.Vertical * movementSpeed);
        var playerVelocity = player_rb.velocity;

        if (playerVelocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            facingDirection = Direction.Right;
        }
        else if (playerVelocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            facingDirection = Direction.Left;
        }

        if (playerVelocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            facingDirection = Direction.Up;
        }
        else if (playerVelocity.y < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            facingDirection = Direction.Down;
        }
    }
}

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}
