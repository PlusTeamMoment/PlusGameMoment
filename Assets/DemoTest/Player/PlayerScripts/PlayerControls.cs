using UnityEngine;

public class PlayerControls : MonoBehaviour, INullablePlayerControls
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }
    public bool WeaponMainAttack { get; set; }
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1")) WeaponMainAttack = true;
        else WeaponMainAttack = false;
    }
}
