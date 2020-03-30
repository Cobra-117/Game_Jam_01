using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speedmult_x;
    public float speedmult_y;
    public float border_right;
    public float border_left;
    public float border_top;
    public float border_bottom;
    public GLOBAL mother_scr;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed_x = 1 * speedmult_x;
        float speed_y = 1 * speedmult_y;
        transform.Translate(speed_x, speed_y, 0);
        if (transform.position.x > border_right || transform.position.x < border_left
            || transform.position.y > border_top || transform.position.y < border_bottom)
        {
            Destroy(this.gameObject);
        }
    }
}
