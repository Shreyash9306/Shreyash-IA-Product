using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderRotate2 : MonoBehaviour
{
    public GameObject ladder;
    private float zRotation;
    public GameObject ladder_2;
    public Transform end;
    public Transform start;
    private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        extend();
    }
    public void Rotate()
    {
        zRotation = ladder.transform.eulerAngles.z;
        if (Input.GetKey(KeyCode.LeftArrow))
            ladder.transform.Rotate(0f, 0f, 15 * Time.deltaTime, Space.Self);
        if (Input.GetKey(KeyCode.RightArrow))
            ladder.transform.Rotate(0f, 0f, -15 * Time.deltaTime, Space.Self);
    }
    public void extend()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            ladder_2.transform.position = Vector2.MoveTowards(ladder_2.transform.position, end.transform.position, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            ladder_2.transform.position = Vector2.MoveTowards(ladder_2.transform.position, start.transform.position, speed * Time.deltaTime);
    }
}
