using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEssence : MonoBehaviour
{
    private const int MAXVALUE = 100;
    private Dictionary<string, int> essences;
    public static Action<string, int, int, Dictionary<string, int>> onEssenceUpdate;

    private void Awake()
    {
        essences = new Dictionary<string, int>();
    }

    private void Start()
    {
        Enemy.onKill += EssenceInsert;
    }

    private void EssenceInsert(string essenceName, int essenceFillValue)
    {
        if (essences.ContainsKey(essenceName)) UpdateEssenceFillValue(essenceName, essenceFillValue);
        else AddNewEssence(essenceName, essenceFillValue);

    }

    private void AddNewEssence(string name, int value)
    {
        essences.Add(name, value);
        onEssenceUpdate?.Invoke(name, value, MAXVALUE, essences);
    }

    private void UpdateEssenceFillValue(string name, int value)
    {
        essences[name] = Mathf.Clamp(essences[name] + value, 0, MAXVALUE);
        onEssenceUpdate?.Invoke(name, essences[name], MAXVALUE, essences);
    }
}
