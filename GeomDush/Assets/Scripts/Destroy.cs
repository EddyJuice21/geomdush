using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private float startTime;
    [SerializeField] private float endTime;
    
    void FixedUpdate()
    {
        startTime += 0.1f;
        if (startTime >= endTime)
        {
            Destroy(gameObject);
        }
    }
}
