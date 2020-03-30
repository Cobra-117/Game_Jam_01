using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    private float length, startpos;
    public float parallaxEffect, border;

    // Start is called before the first frame update
    void Start()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 1 * parallaxEffect * Time.deltaTime;

        transform.Translate(0, -speed, 0);
        if (transform.position.y < -length)
        {
            transform.position = new Vector3(transform.position.x, length, transform.position.z);
        }
    }
}