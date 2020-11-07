using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EssenceUI : MonoBehaviour
{
    [SerializeField] private Text textEssence;
    [SerializeField] private Text dictionaryUI;

    private void Start()
    {
        PlayerEssence.onEssenceUpdate += UpdateCounter;
    }

    private void UpdateCounter(string name, int value, int maxValue, Dictionary<string, int> essences)
    {
        textEssence.text = name + ": " + value + " / " + maxValue;
        dictionaryUI.text = "";
        foreach (var essence in essences)
        {
            dictionaryUI.text += essence.Key.ToString() + " : " + essence.Value + " / " + maxValue + "\n";
        }
    }
}
