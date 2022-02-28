using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMonster", menuName = "ScriptableObject/Monster", order = 0)]
public class Monstre_SO : ScriptableObject
{
    public string monsterName;
    public Sprite monsterSprite;
    public int hpMin, hpMax, moneyMin, moneyMax;
}