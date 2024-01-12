using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float rand = 0f;

    public Transform floor1;
    public Transform floor2;
    public Transform floor3;
    public Transform floor4;

    public GameObject fire;

    public GameObject civillian;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 5);
        if (rand == 1)
        {
            Instantiate(fire, floor1.transform.position, Quaternion.identity);
            Instantiate(civillian, floor1.transform.position, Quaternion.identity);
        }
        if (rand == 2)
        {
            Instantiate(fire, floor2.transform.position, Quaternion.identity);
            Instantiate(civillian, floor2.transform.position, Quaternion.identity);
        }
        if (rand == 3)
        {
            Instantiate(fire, floor3.transform.position, Quaternion.identity);
            Instantiate(civillian, floor3.transform.position, Quaternion.identity);
        }
        if (rand == 4)
        {
            Instantiate(fire, floor4.transform.position, Quaternion.identity);
            Instantiate(civillian, floor4.transform.position, Quaternion.identity);
        }
    }
}
