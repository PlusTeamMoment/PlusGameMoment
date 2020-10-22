using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementDivisionValue;
    [SerializeField] private PlayerControls playerControls;
    private Rigidbody2D player_rb;

    void Awake()
    {
        player_rb = GetComponent<Rigidbody2D>();
        if (playerControls == null) print("playerControls is MISSING!");
    }

    private void Start()
    {
        movementSpeed /= movementDivisionValue;
    }

    void FixedUpdate()
    {
        player_rb.velocity = new Vector2(playerControls.Horizontal * movementSpeed, playerControls.Vertical * movementSpeed);
    }
}
