using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastLaser : MonoBehaviour
{
    private float t;
    private LineRenderer lr;

    [SerializeField]
    private Transform blipBloup;

    [SerializeField]
    private float speed;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mouseWorldPos = new Vector3(worldPos.x, worldPos.y, 0);

            blipBloup.position = mouseWorldPos;

            //float distance = Vector3.Distance(mouseWorldPos, transform.position);

            //transform.position = Vector3.Lerp(transform.position, mouseWorldPos, t);

            RaycastHit hit;

            Debug.DrawRay(transform.position, (mouseWorldPos - transform.position) * 12, Color.red);

            if (Physics.Raycast(transform.position, (mouseWorldPos - transform.position), out hit, Mathf.Infinity))
            {
                Debug.Log("oui");
            }

            //t += Time.deltaTime / distance * speed;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            t = 0;
        }
    }
}