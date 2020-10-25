using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullPlayerControls : INullablePlayerControls
{
    public float Horizontal { get; set; }
    public float Vertical { get; set; }
    public bool WeaponMainAttack { get; set; }
}
