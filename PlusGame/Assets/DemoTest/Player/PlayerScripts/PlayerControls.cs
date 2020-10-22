using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Movement
    public float Horizontal { get; private set; }
    public float Vertical { get; private set; }
    //Attacks
    public bool weaponMainAttack;
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1")) weaponMainAttack = true;
        else weaponMainAttack = false;
    }
}
