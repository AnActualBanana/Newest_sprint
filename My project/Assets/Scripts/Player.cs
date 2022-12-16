using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 3;
    public float moveSpeed = 10.0f;
    public int score = 0;

    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        MovePlayer ();
    }

    public void MovePlayer()
    {
        player.velocity = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy(Clone)")
        {
            health -= 1;
        }
    }
}
