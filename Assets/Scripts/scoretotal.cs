using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoretotal : MonoBehaviour
{
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public TextMeshProUGUI score3;

    // Start is called before the first frame update
    void Start()
    {
        score1.text = scorecontroller.score1;
        score2.text = scorecontroller.score2;
        score3.text = scorecontroller.score3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
