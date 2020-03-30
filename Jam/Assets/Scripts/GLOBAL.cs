using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GLOBAL : MonoBehaviour
{
    public float chrono;
    private float init_time;
    public int score = 0;
    int has_displayed_score = 0;
    int result;
    public static int stat_score = 0;
    public int stat_scr_int = 0;

    // Update is called once per frame

    void Start()
    {
        init_time = Time.time;
    }
    void Update()
    {
        stat_scr_int = stat_score;
        if (stat_score != 0 || stat_scr_int != 0)
            return;
        if (chrono < 0 && has_displayed_score == 0)
        {
            has_displayed_score = 1;
            stat_score = score;
            SceneManager.LoadScene("End", LoadSceneMode.Single);
        }
        else if (chrono >= 0)
        {
            chrono = 90 - (Time.time - init_time);
        }
    }
}
