using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclicker : MonoBehaviour
{
    [SerializeField]
    private Monster monster;

    private GameManager gm;

    public bool canAutoclik = true;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();

        if (canAutoclik)
        {
            StartCoroutine(Autoclicking());
        }
    }

    private IEnumerator Autoclicking()
    {
        while (true)
        {
            if (!monster.dead)
            {
                monster.AutoclickerHit();
            }
            yield return new WaitForSeconds(1f / gm.autoClickerDelay);
        }
    }
}