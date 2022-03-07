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
        if (monsterTemplate == null)                // si aucun template de monstre n'est sélectionné
        {
            timer += Time.deltaTime;
        }
        if (timer > 0.5f)                           // timer de 0.5s
        {
            SpawnMonster();                         // débute le spawn de monstre
            timer = 0;
        }
    }

    public void SpawnMonster()
    {
        NewMonster();                                       // choisit un monstre aléatoirement parmi la liste de tous les monstres renseignée

        monster.GetComponent<SpriteRenderer>().sprite = monsterTemplate.monsterSprite;                  // sprite
        monster.maxHp = Random.Range(monsterTemplate.hpMin, monsterTemplate.hpMax + 1);                 // maxHp
        monster.hp = monster.maxHp;                                                                     // hp = maxHp
        monster.gold = Random.Range(monsterTemplate.moneyMin, monsterTemplate.moneyMax + 1);            // gold
        monsterNameText.text = monsterTemplate.monsterName;                                             // name

        monster.transform.localScale = new Vector3(1, 1, 1);                                            // scale à 1

        gauge.SetToAlive();                                                                             // jauge alive

        monster.dead = false;                                                                           // monstre en vie

        Debug.LogWarning(monsterTemplate.monsterName + " - " + monster.hp);
    }

    private void NewMonster()                                   // choisit un monstre aléatoirement parmi la liste de tous les monstres renseignée
    {
        int rand = Random.Range(0, tousLesMonstres.Count);
        monsterTemplate = tousLesMonstres[rand];
    }
}