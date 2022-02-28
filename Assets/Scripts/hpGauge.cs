using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpGauge : MonoBehaviour
{
    [SerializeField]
    private Monster monster;

    [SerializeField]
    private List<SpriteRenderer> srToDisable;

    [SerializeField]
    private Transform gaugeParent;

    [SerializeField]
    private SpriteRenderer srGauge;

    public void SetToDead()
    {
        for (int i = 0; i < srToDisable.Count; i++)
        {
            srToDisable[i].enabled = false;
        }
    }

    public void SetToAlive()
    {
        gaugeParent.localScale = new Vector3(1, 1, 1);
        srGauge.color = Color.green;

        for (int i = 0; i < srToDisable.Count; i++)
        {
            srToDisable[i].enabled = true;
        }
    }

    public void UpdateGauge()
    {
        int maxHp = monster.maxHp;
        int hp = monster.hp;

        float newX = (float)hp / (float)maxHp;

        gaugeParent.localScale = new Vector3(newX, gaugeParent.localScale.y, gaugeParent.localScale.z);
        srGauge.color = Color.Lerp(Color.green, Color.red, 1 - newX);
    }
}