using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawner : MonoBehaviour
{

    public float spawn_timer; //seconds between enemy spawns
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn_enemy(spawn_timer, myPrefab));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator spawn_enemy(float spawn_timer, GameObject enemy) // spawns enemy
    {
        yield return new WaitForSeconds(spawn_timer);
        Instantiate(enemy, new Vector3(Random.Range(15, 25), 23), Quaternion.identity);
        StartCoroutine(spawn_enemy(spawn_timer, myPrefab));
    }
}
