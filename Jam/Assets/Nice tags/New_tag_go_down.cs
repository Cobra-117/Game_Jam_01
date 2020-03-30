using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_tag_go_down : MonoBehaviour
{
    public float parallaxEffect;

    // Update is called once per frame
    void Update()
    {
        float speed = 1 * parallaxEffect * Time.deltaTime;

        transform.Translate(0, -speed, 0);
    }
}
