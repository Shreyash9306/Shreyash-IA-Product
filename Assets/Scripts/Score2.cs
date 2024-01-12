using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score2 : MonoBehaviour
{

    public TextMeshProUGUI scoredis;
    public int ss;
    // Start is called before the first frame update
    void Start()
    {
        ss = Random.Range(65, 88);
        scoredis.text = "Scenario 2 Score: " + ss;
        scorecontroller.score2 = scoredis.text;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
