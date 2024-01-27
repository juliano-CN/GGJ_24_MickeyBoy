using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
    [SerializeField]
    GameObject house;
    [SerializeField]
    Vector2 spawnIntervalRange;

    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(spawnIntervalRange.x, spawnIntervalRange.y));
            GameObject _house = Instantiate(house, transform.position, Quaternion.identity);
            Destroy(_house, 10);
        }
    }
}
