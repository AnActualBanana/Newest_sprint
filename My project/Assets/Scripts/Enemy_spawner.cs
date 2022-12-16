using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawner : MonoBehaviour
{

    public float spawn_timer = 60; //frames between enemy spawns
    public float initial_spawn_timer = 60;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn_timer > 0)
        {
            spawn_timer -= 1;
        }
        else
        {
            spawn_enemy();
            spawn_timer = initial_spawn_timer;
        }
    }

    void spawn_enemy ()
    {
        Instantiate(gameObject, new Vector3(0, 11), Quaternion.identity);
    }
}
