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

    private Monstre_SO monsterTemplate;

    private float timer;

    private void Update()
    {
        if (monsterTemplate == null)
        {
            timer += Time.deltaTime;
        }
        if (timer > 2)
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

        monster.GetComponent<SpriteRenderer>().sprite = monsterTemplate.monsterSprite;
        monster.hp = Random.Range(monsterTemplate.hpMin, monsterTemplate.hpMax + 1);
        monster.gold = Random.Range(monsterTemplate.moneyMin, monsterTemplate.moneyMax + 1);
        monsterNameText.text = monsterTemplate.monsterName;
    }
}