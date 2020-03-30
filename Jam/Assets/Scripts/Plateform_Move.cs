using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform_Move : MonoBehaviour
{
    public bool Must_move = false;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Must_move == false)
            return;
        transform.Translate(0, Speed * Time.deltaTime, 0);
    }
}
