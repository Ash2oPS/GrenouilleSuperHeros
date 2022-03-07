using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private MonsterSpawner monsterSpawner;

    public float maxHp, hp;
    public int gold;

    [HideInInspector]
    public bool dead = true;

    private GameManager gm;

    [SerializeField]
    private TextMesh monsterNameText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private hpGauge gauge;

    private float timer;

    private void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        //if (isDying)
        //{
        //    if (timer < 0.15)
        //    {
        //        timer += Time.deltaTime;
        //    }
        //    else
        //    {
        //        timer = 0;
        //        isDying = false;
        //        Die();
        //    }
        //}
    }

    public void LoseHP(float value, bool isAuto)
    {
        if (!dead)
        {
            hp -= value;

            if (hp <= 0)
            {
                hp = 0;

                animator.SetTrigger("Die");
            }
            else if (!isAuto)
            {
                animator.SetTrigger("Hit");
            }
        }

        gauge.UpdateGauge();
    }

    public void Die()
    {
        dead = true;
        monsterSpawner.monsterTemplate = null;
        GetComponent<SpriteRenderer>().sprite = null;
        gm.AddGold(gold);
        monsterNameText.text = "";

        gauge.SetToDead();
    }

    public void Hit()
    {
        LoseHP(gm.damagePerClick, false);
    }

    public void AutoclickerHit()
    {
        print("coucou");
        LoseHP(gm.damageAutoclicker / gm.autoClickerDelay, true);
    }
}