using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float movementDivisionValue;
    [SerializeField] private PlayerControls playerControls;

    void Awake()
    {
        if (playerControls == null) print("playerControls is MISSING!");
    }

    private void Start()
    {
        movementSpeed /= movementDivisionValue;
    }

    void Update()
    {
        if (playerControls.rightInput == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            transform.position += new Vector3(movementSpeed, 0, 0);
        }
        if (playerControls.leftInput == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
            transform.position += new Vector3(-movementSpeed, 0, 0);
        }
        if (playerControls.topInput == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.position += new Vector3(0, movementSpeed, 0);
        }
        if (playerControls.bottomInput == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += new Vector3(0, -movementSpeed, 0);
        }
    }
}
