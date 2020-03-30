using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{
    public Rigidbody2D plr;
    public float speed = 2.5f;
    public float jumph = 7.0f;
    public float inertie = 0.3f;
    public bool is_grounded;

    void Start() { print("Start"); }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q");
            plr.velocity -= new Vector2(inertie, 0);
            if (plr.velocity.x < -speed) plr.velocity = new Vector2(-speed, plr.velocity.y);
            transform.localScale = new Vector3(-0.4f, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            plr.velocity += new Vector2(inertie, 0);
            if (plr.velocity.x > speed) plr.velocity = new Vector2(speed, plr.velocity.y);
            transform.localScale = new Vector3(0.4f, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.Space) && is_grounded)
        {
            plr.velocity += new Vector2(0, jumph);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            is_grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            is_grounded = false;
        }
    }
}
