using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField]
    float speed;

    public Sprite[] sprite;
    SpriteRenderer sr;
    SpawnHouse sh;

    void Start()
    {
        int r = Random.Range(0, 3);
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = sprite[r];
    }

    private void FixedUpdate()
    {
        transform.position -= new Vector3(0, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bread")
        {
            Destroy(collision);
        }
    }

}
