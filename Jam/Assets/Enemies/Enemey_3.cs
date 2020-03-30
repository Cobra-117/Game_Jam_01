using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey_3 : MonoBehaviour
{
    public float fr;
    public float speed;
    public GameObject player;
    public Rigidbody2D _this;

    // Update is called once per frame
    void Update()
    {
        Vector2 drctn;
        _this.velocity *= fr;

        drctn.x = player.transform.position.x - _this.position.x;
        drctn.y = player.transform.position.y - _this.position.y;
        drctn.x *= ((drctn.x / Mathf.Sqrt(Mathf.Pow(drctn.x, 2) + Mathf.Pow(drctn.y, 2))) * speed);
        drctn.y *= ((drctn.y / Mathf.Sqrt(Mathf.Pow(drctn.x, 2) + Mathf.Pow(drctn.y, 2))) * speed);
        _this.velocity -= drctn;
    }
}