using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_moves : MonoBehaviour
{
    public float height_limit;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (transform.position.y < height_limit)
            Destroy(this.gameObject);
    }
}
