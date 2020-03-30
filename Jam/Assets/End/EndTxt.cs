using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTxt : MonoBehaviour
{
    public Text txt;
    public GLOBAL mother_scr;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = mother_scr.stat_scr_int.ToString();
    }
}
