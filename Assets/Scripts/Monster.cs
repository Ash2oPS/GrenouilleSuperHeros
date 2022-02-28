using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private MonsterSpawner monsterSpawner;

    public int maxHp, hp, gold;

    [HideInInspector]
    public bool isDying = false, dead = true;

    private GameManager gm;

    [SerializeField]
    private TextMesh monsterNameText;

    [SerializeField]
    private AnimTransform animTransformHit, animTransformDie;

    [SerializeField]
    private hpGauge gauge;

    private float timer;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if (isDying)
        {
            if (timer < 0.15)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
                isDying = false;
                Die();
            }
        }
    }

    public void LoseHP(int value)
    {
        if (!isDying && !dead)
        {
            hp -= value;

            if (hp <= 0)
            {
                Dying();
                hp = 0;
            }
        }

        gauge.UpdateGauge();
    }

    private void Dying()
    {
        isDying = true;

        animTransformDie.SetCanGo();
    }

    private void Die()
    {
        monsterSpawner.monsterTemplate = null;
        GetComponent<SpriteRenderer>().sprite = null;
        gm.AddGold(gold);
        monsterNameText.text = "";

        gauge.SetToDead();

        transform.localScale = new Vector3(1, 1, 1);
    }

    public void AnimHit()
    {
        if (!dead && !isDying)
        {
            animTransformHit.SetCanGo();
        }
    }
}