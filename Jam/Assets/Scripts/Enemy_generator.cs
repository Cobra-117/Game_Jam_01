using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_generator : MonoBehaviour
{
    public GameObject Hit;
    public GameObject push;
    public GameObject head;
    public float saved_time;
    public float delay;
    public int enemy_limit;

    // Update is called once per frame

    void Start()
    {
        saved_time = Time.time;
    }

    void Update()
    {
        float new_time = Time.time;

        if (new_time >= saved_time + delay)
        {
            saved_time = new_time;
            //Debug.Log("pop enemy\n");
            pop_enemy();
            delay = delay * 0.99f;
        }
    }

    void pop_enemy()
    {
        //Check si on peut le faire pop
        GameObject enemy = choose_enemy();
        GameObject popped_enemy;

        popped_enemy = Instantiate(enemy, transform.position, transform.rotation);
        popped_enemy.transform.position = get_random_pos();
        popped_enemy.tag = "Enemy";
        
    }

    public GameObject choose_enemy()
    {
        int choice;

        choice = Random.Range(1, 3);
        switch (choice)
        {
            case 1:
                return (Hit);
            case 2:
                return (push);
            case 3:
                return (head);
        }
        return (push);
    }

    Vector3 get_random_pos()
    {
        Vector3 pos;

        pos.x = Random.Range(-8.0f, 9.0f);
        pos.y = 5;
        pos.z = -1;

        return (pos);
    }
}
