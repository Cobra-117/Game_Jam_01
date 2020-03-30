using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projec_movements : MonoBehaviour
{
    public float speedmult_x;
    public float speedmult_y;
    public float border_right;
    public float border_left;
    public float border_top;
    public float border_bottom;
    public GameObject tag_1, tag_2, tag_3;
    public GLOBAL mother_scr;
    public GameObject mother_obj;

    // Start is called before the first frame update
    void Start()
    {
        mother_obj = GameObject.FindGameObjectWithTag("Essential");
        mother_scr = mother_obj.GetComponent<GLOBAL>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed_x = 1 * speedmult_x;
        float speed_y = 1 * speedmult_y;
        transform.Translate(speed_x * Time.deltaTime, speed_y * Time.deltaTime, 0);
        if (transform.position.x > border_right || transform.position.x < border_left
            || transform.position.y > border_top || transform.position.y < border_bottom)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger enter");
        if (other.tag == "Enemy")
        {
            mother_scr.score += 1;
            pop_new_tag(other.gameObject);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    void pop_new_tag(GameObject enemy)
    {
        GameObject choosed_tag = choose_new_tag();
        GameObject new_one = Instantiate(choosed_tag, transform.position, transform.rotation);
        new_one.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y, -1);
        new_one.transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public GameObject choose_new_tag()
    {
        int choice;

        choice = Random.Range(1, 4);
        switch (choice)
        {
            case 1:
                return (tag_1);
            case 2:
                return (tag_2);
            case 3:
                return (tag_3);
        }
        return (tag_1);
    }
}
