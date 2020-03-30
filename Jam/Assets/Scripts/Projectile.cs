using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectile;
    public GameObject generated;

    public GameObject blue;
    public GameObject red;
    public GameObject green;
    public GameObject purple;
    public GameObject orange;

    public float angle_offset;
    public float saved_time_1;
    public float cooldown;

    // Update is called once per frame
    void Update()
    {
        float angle;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos;
            float cur_time = Time.time;
            if (cur_time >= saved_time_1 + cooldown)
            {
                saved_time_1 = cur_time;
            }
            else
                return;
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            angle = calc_angle(pos);
            for (int i = 0; i < 3; i++)
            {
                projectile = choose_random_color();
                generated = Instantiate(projectile, transform.position, transform.rotation);
                generated.transform.eulerAngles = new Vector3(generated.transform.rotation.x, generated.transform.rotation.y, angle);
                generated.transform.localPosition = new Vector3(generated.transform.localPosition.x + i,
                generated.transform.localPosition.y + i, generated.transform.localPosition.z);

            }
        }
    }

    public float calc_angle(Vector2 target)
    {
        float quarter = 0;
        float angle = 0;

        //pos finding
        float dist_x = transform.position.x - target.x;
        float dist_z = transform.position.y - target.y;
        float posi_x = transform.position.x - target.x;
        float posi_z = transform.position.y - target.y;

        //quarter finding
        if (posi_x < 0)
            posi_x = posi_x * (-1);
        if (posi_z < 0)
            posi_z = posi_z * (-1);
        float dist = (posi_x + posi_z);

        if (dist_x > 0 && dist_z > 0)
            quarter = 2;
        else if (dist_x > 0 && dist_z < 0)
            quarter = 1;
        else if (dist_x < 0 && dist_z < 0)
            quarter = 0;
        else if (dist_x < 0 && dist_z > 0)
            quarter = 3;
        else
            quarter = -1;

        //angle finding
        if (quarter == 3 || quarter == 1)
            angle = 90 * (posi_x / dist) - angle_offset + (90 * quarter);
        else if (quarter == 0 || quarter == 2)
            angle = 90 * (posi_z / dist) - angle_offset + (90 * quarter);
        Debug.Log(quarter);
        return (angle);

    }

    public GameObject choose_random_color()
    {
        int chosen_nbr = Random.Range(1, 6);

        switch (chosen_nbr)
        {
            case 1:
                return (blue);
            case 2:
                return (red);
            case 3:
                return (green);
            case 4:
                return (orange);
            case 5:
                return (purple);
        }
        return (purple);
    }
}
