using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text timerTextRes;

    float startTime;
    bool finnished = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (finnished)
        {
            return;
        }
        else
        {
            float time = Time.time - startTime;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f1");

            timerText.text = minutes + ":" + seconds;
            timerTextRes.text = minutes + ":" + seconds;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ball")
        {
            finnished = true;
        }
    }
}