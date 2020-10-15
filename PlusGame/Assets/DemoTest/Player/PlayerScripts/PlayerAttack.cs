using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] float attackDamage;
    [SerializeField] private PlayerControls playerControls;
    [SerializeField] private GameObject attackHitbox;
    [SerializeField] private float maxTimer;
    private float currentTimerStatus;
    private bool timerState;

    private void Awake()
    {
        if (playerControls == null) print("playerControls is MISSING!");
    }

    private void Start()
    {
        timerState = false;
        currentTimerStatus = maxTimer;
    }

    private void Update()
    {
        if (playerControls.weaponMainAttack == true)
        {
            timerState = true;
        }
        if (timerState == true)
        {
            Timer();
        }
        attackHitbox.SetActive(timerState);
    }

    void Timer()
    {
        if (currentTimerStatus > 0)
        {
            currentTimerStatus -= Time.deltaTime;
        }
        else
        {
            currentTimerStatus = maxTimer;
            timerState = false;
        }
    }
}
