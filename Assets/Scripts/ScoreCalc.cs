using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCalc : MonoBehaviour
{
    double score = 100;
    Extinguish e;
    FireTruck ft;
    ladderRotate lr;
    civvierescue c;
    public double time = 0;
    public bool running = true;
    public TMP_Text Score1;
    public TMP_Text TimeElapsed;
    float timeelapsed;

    void Update()
    {
        while (running)
        {
            time += Time.deltaTime * 0.1;
            if (ft.locker == false && lr.ismoving == true)
                score -= Time.deltaTime * 0.2;
            if (ft.locker == false && ft.ismoving == true)
                score -= Time.deltaTime * 0.2;
            timeelapsed += Time.deltaTime;
        }
        if (e.firesdone == 3)
        {
            running = false;
            Score1.text = score.ToString();
            TimeElapsed.text = timeelapsed.ToString();
        }
    }
    void calculator()
    {
        if (running == false)
        {
            score += e.fireScore + c.civviescore;
        }
    }
}
