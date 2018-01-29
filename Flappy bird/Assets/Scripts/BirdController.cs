using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    private bool isDead = false;
    private Rigidbody2D rb2d;
    public float force = 200f;
    private Animator anim;

	void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, force));
                anim.SetTrigger("Flap");
            }
        }
	}

    void OnCollisionEnter2D ()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        gameController.instance.BirdDied();
    }
}
