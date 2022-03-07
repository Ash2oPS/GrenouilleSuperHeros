using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int gold;

    public float damagePerClick, damageAutoclicker, autoClickerDelay;

    [SerializeField]
    private TextMesh goldText;

    private void Update()
    {
        if (int.Parse(goldText.text) != gold)
        {
            UpdateText();
        }
    }

    private void UpdateText()
    {
        goldText.text = gold.ToString();
    }

    public void AddGold(int value)
    {
        gold += value;

        if (gold < 0)
        {
            gold = 0;
        }
    }
}