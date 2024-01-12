using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class practice1score : MonoBehaviour
{
    Extinguish e;
    public GameObject water;

    void Awake()
    {
        e = water.GetComponent<Extinguish>();
    }

    void Update()
    {
        if (e.firesdone == 1)
            SceneManager.LoadScene("Score1");
    }
}
