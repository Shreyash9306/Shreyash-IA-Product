using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TextMeshProUGUI scoredis;
    public int ss;
    // Start is called before the first frame update
    void Start()
    {
        ss = Random.Range(65, 88);
        scoredis.text = "Scenario 1 Score: " + ss;
        scorecontroller.score1 = scoredis.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
