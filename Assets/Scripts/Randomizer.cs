using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    public GameObject fire;
    public int firecount = 0;
    // Start is called before the first frame update
    public Transform[] points;
    void Update()
    {
        fires();
    }

    public void fires()
    {
        while (firecount <= 100)
        {
            int randpoint = Random.Range(0, points.Length);
            Instantiate(fire, points[randpoint].position, Quaternion.identity);
            firecount += 1;
        }
    }
}
