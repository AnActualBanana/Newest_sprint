using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public Rigidbody2D enemy; //reference to itself

    public float moveSpeed = 0.001f;

    public bool changeDirection = false;

    public Animator anim;

    public GameObject spawner;

    public GameObject player;

    public GameObject Enemy_new;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player_projectile(Clone)" || col.gameObject.name == "Player")
        {
            anim.SetTrigger("PopTr");
            moveSpeed = 0f;
            enemy.gravityScale = 0;
            enemy.simulated = false;
            player.GetComponent<Player>().score += 1;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        enemy = this.gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(-2.0f, 2.0f);
        enemy.mass = Random.Range(1.0f, 8.0f);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    public void moveEnemy()
    {
        if (enemy != null) {
            enemy.velocity = new Vector2(1, 0) * moveSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Right Wall" || col.gameObject.name == "Left Wall" || col.gameObject.name == "Enemy(Clone)")
        {
            changeDirection = true;
            moveSpeed = moveSpeed * -1;
        }
        if (col.gameObject.name == "Bottom Wall")
        {
            Enemy_new = Instantiate(Enemy_new, new Vector3(Random.Range(15, 25), 23), Quaternion.identity);
            Enemy_new.GetComponent<Enemy>().name = this.gameObject.GetComponent<Enemy>().name;
            Destroy(this.gameObject);
        }
    }
}
