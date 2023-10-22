using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(6f * Time.deltaTime, 0, 0);
    }
}
