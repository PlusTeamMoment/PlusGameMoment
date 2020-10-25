using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INullablePlayerControls
{
    float Horizontal { get; set; }
    float Vertical { get; set; }
    bool WeaponMainAttack { get;  set; }
}
