using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_2 : MonoBehaviour
{
    public float height_limit;
    public float speed;
    public float direction;

    void Start()
    {
        direction = Random.Range(0.0f, 1.9f);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 dp = new Vector3();

        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (transform.position.y < height_limit)
            Destroy(this.gameObject);
        if (direction >= 1)
            dp.x += speed;
        else
            dp.x -= speed;
        dp.y -= speed;

        transform.position += dp * Time.deltaTime;
    }
}