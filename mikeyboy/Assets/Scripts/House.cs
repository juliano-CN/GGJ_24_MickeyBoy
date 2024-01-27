using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField]
    float speed;

    private void FixedUpdate()
    {
        transform.position -= new Vector3(0, speed);
    }

}
