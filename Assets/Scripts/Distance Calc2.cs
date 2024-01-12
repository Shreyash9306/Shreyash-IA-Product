using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DistanceCalc2 : MonoBehaviour
{
    [SerializeField] Transform top;
    [SerializeField] Transform back;

    public TextMeshProUGUI extension;
    public TextMeshProUGUI rotation;
    public TextMeshProUGUI stopwatch;

    public float time = 90f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        extension.text = "Extension: " + (top.transform.position * 2 - back.transform.position * 2).magnitude.ToString("0.00");
        rotation.text = "Rotation: " + back.eulerAngles.z.ToString("0.00") + "°";
        if (time > 0)
            time -= Time.deltaTime;
        else
            time = 0;
        display(time);
    }
    void display(float timer)
    {
        if (timer < 0)
        {
            timer = 0;
            SceneManager.LoadScene("Score2");
        }
        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);
        stopwatch.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
