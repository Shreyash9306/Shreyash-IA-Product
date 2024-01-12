using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceCalc : MonoBehaviour
{

    [SerializeField] Transform top;
    [SerializeField] Transform ground;
    [SerializeField] Transform back;

    public TextMeshProUGUI elevation;
    public TextMeshProUGUI extension;

    // Update is called once per frame
    void Update()
    {
        elevation.text = "Elevation: " + (top.transform.position*2 - ground.transform.position * 2).magnitude.ToString("0.00");
        extension.text = "Extension: " + (top.transform.position * 2 - back.transform.position * 2).magnitude.ToString("0.00");
    }
}
