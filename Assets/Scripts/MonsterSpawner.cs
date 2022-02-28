using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [Header("TOUS LES TEMPLATES DE MONSTRES")]
    [SerializeField]
    private List<Monstre_SO> tousLesMonstres;

    [SerializeField]
    private Monster monster;

    [SerializeField]
    private TextMesh monsterNameText;

    [HideInInspector]
    public Monstre_SO monsterTemplate;

    private float timer;

    [SerializeField]
    private hpGauge gauge;

    private void Update()
    {
        if (monsterTemplate == null)
        {
            timer += Time.deltaTime;
        }
        if (timer > 0.5f)
        {
            SpawnMonster();
            timer = 0;
        }
    }

    private void NewMonster()
    {
        int rand = Random.Range(0, tousLesMonstres.Count);
        monsterTemplate = tousLesMonstres[rand];
    }

    public void SpawnMonster()
    {
        NewMonster();

        monster.dead = false;

        monster.GetComponent<SpriteRenderer>().sprite = monsterTemplate.monsterSprite;
        monster.maxHp = Random.Range(monsterTemplate.hpMin, monsterTemplate.hpMax + 1);
        monster.hp = monster.maxHp;
        monster.gold = Random.Range(monsterTemplate.moneyMin, monsterTemplate.moneyMax + 1);
        monsterNameText.text = monsterTemplate.monsterName;

        gauge.SetToAlive();
    }
}