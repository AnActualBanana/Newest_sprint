using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

    public Rigidbody2D enemy; //reference to itself

    public float moveSpeed = 0.001f;

    public bool changeDirection = false;

    public Animator anim;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player_projectile(Clone)")
        {
            Debug.Log("Projectile");
            anim.SetTrigger("PopTr");
            moveSpeed = 0f;
            enemy.gravityScale = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        enemy = this.gameObject.GetComponent<Rigidbody2D>();
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
            if (changeDirection == true)
                {
                    enemy.velocity = new Vector2(1, 0) * -1 * moveSpeed;
                }
            else if (changeDirection == false)
                {
                    enemy.velocity = new Vector2(1, 0) * moveSpeed;
                }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Right Wall")
        {
            Debug.Log("Hit right wall");
            changeDirection = true;
        }
        if (col.gameObject.name == "Left Wall")
        {
            Debug.Log("Hit left wall");
            changeDirection = false;
        }
    }
}
