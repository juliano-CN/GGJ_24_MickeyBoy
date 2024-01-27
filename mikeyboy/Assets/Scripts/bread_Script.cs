using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread_Script : MonoBehaviour
{
    public points points;
    [SerializeField] int pointValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "house")
        {
            points.addPoint(pointValue);
            Destroy(collision);
        }
    }
}
