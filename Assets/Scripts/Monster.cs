using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int hp, gold;

    public void LoseHP(int value)
    {
        hp -= value;

        if (hp < 0)
        {
            hp = 0;
        }
    }
}