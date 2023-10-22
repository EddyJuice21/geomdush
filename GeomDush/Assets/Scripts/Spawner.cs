using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Spawn;
    [SerializeField] private GameObject Hole;
    [SerializeField] private GameObject Portal;
    private float holeTimer;
    private float portalTimer;

    private void Start()
    {
        portalTimer = 10f;
    }

    private void Update()
    {
        if (holeTimer <= 0)
        {
            if (portalTimer > 1f)
            {
                holeTimer = Random.Range(1, 3);
                var hole = Instantiate(Hole, transform.position, Quaternion.identity) as GameObject;
            }
            else
            {
                holeTimer = 5f;
            }
                
        }
        else
        {
            holeTimer -= Time.deltaTime;
        }
        
        if (portalTimer <= 0)
        {
            portalTimer = Random.Range(10, 15);
            var portal = Instantiate(Portal, Portal.transform.position, Quaternion.identity) as GameObject;
        }
        else
        {
            portalTimer -= Time.deltaTime;
        }
        
    }

}