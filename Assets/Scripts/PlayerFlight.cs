using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlight : MonoBehaviour
{
    private float t;

    [SerializeField]
    private float speed;

    private void Start()
    {
        speed /= 10;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mouseWorldPos = new Vector3(worldPos.x, worldPos.y, 0);

            float distance = Vector3.Distance(mouseWorldPos, transform.position);

            transform.position = Vector3.Lerp(transform.position, mouseWorldPos, t);

            t += Time.deltaTime / distance * speed;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            t = 0;
        }
    }
}