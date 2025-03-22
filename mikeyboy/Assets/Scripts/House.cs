using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField]
    float speed;

    public Sprite[] sprite;
    [SerializeField] SpriteRenderer sr;

    void Start()
    {
        int r = Random.Range(0, 3);
        sr.sprite = sprite[r];
    }

    private void FixedUpdate()
    {
        transform.position -= new Vector3(0, speed);
    }

}
