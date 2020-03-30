using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    public GameObject followed;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3 (this.transform.position.x, followed.transform.position.y, this.transform.position.z);
    }
}
