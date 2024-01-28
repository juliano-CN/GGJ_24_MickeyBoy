using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouse : MonoBehaviour
{
    [SerializeField]
    GameObject house;
    [SerializeField]
    Vector2 spawnIntervalRange;
    [SerializeField] public Vector3 rotat;
    [SerializeField] public bool canSpawn = true;


    void Start()
    {
        StartCoroutine(nameof(Spawn));
    }

    IEnumerator Spawn()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(Random.Range(spawnIntervalRange.x, spawnIntervalRange.y));
            GameObject _house = Instantiate(house, transform.position, Quaternion.Euler(rotat));//Quaternion.Euler(rotat)
            Destroy(_house, 10);
        }
    }
}
