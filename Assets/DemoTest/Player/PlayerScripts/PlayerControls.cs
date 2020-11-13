using UnityEngine;

public class PlayerControls : MonoBehaviour, INullablePlayerControls
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }
    public bool WeaponMainAttack { get; set; }
    public bool InteractionButton { get; set; }
    public bool CloseButton { get; set; }
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1")) WeaponMainAttack = true;
        else WeaponMainAttack = false;
        if (Input.GetKeyDown(KeyCode.E)) InteractionButton = true;
        else InteractionButton = false;
        if (Input.GetKeyDown(KeyCode.Escape)) CloseButton = true;
        else CloseButton = false;
    }
}
