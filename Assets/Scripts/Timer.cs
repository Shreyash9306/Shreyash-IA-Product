using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool running;
    public float remains;

    void Start()
    {
        running = true;
    }

    void Update()
    {
        if (running)
        {
            if (remains >= 0)
            {
                remains += Time.deltaTime;
                timedisplay(remains);
            }
        }
    }
    void timedisplay(float display)
    {
        display += 1;
        float minutes = Mathf.FloorToInt(display / 60);
        float seconds = Mathf.FloorToInt(display % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
