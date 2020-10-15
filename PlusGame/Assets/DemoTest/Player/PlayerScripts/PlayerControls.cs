using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Movement
    public bool rightInput;
    public bool leftInput;
    public bool topInput;
    public bool bottomInput;
    //Attacks
    public bool weaponMainAttack;
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) rightInput = true;
        else rightInput = false;
        if (Input.GetKey(KeyCode.A)) leftInput = true;
        else leftInput = false;
        if (Input.GetKey(KeyCode.W)) topInput = true;
        else topInput = false;
        if (Input.GetKey(KeyCode.S)) bottomInput = true;
        else bottomInput = false;
        if (Input.GetButtonDown("Fire1")) weaponMainAttack = true;
        else weaponMainAttack = false;
    }
}
