using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladderRotate : MonoBehaviour
{

    public GameObject ladder;
    private float zRotation;
    public Transform ladder_2;
    public Transform end;
    public Transform start;
    public float speed = 0.2f;
    int direction = 1;
    public Transform ladder_3;
    public Transform end1;
    public Transform start1;
    int direction1 = 1;
    public GameObject box;
    public bool ismoving;

    void Update()
    {
        Rotate();
        Vector2 target = currentMovementTarget();
        ladder_2.position = Vector2.Lerp(ladder_2.position, target, speed * Time.deltaTime);

        float distance = (target - (Vector2)ladder_2.position).magnitude;

        if (Input.GetKey(KeyCode.UpArrow) && direction == 1)
            direction *= -1;
        if (Input.GetKey(KeyCode.DownArrow) && direction == -1)
            direction *= -1;
        if (Input.GetKey(KeyCode.None))
            speed = 0f;

        Vector2 target1 = currentMovementTarget1();
        ladder_3.position = Vector2.Lerp(ladder_3.position, target1, speed * Time.deltaTime);

        float distance1 = (target1 - (Vector2)ladder_3.position).magnitude;

        if (Input.GetKey(KeyCode.L) && direction1 == 1)
        {
            direction1 *= -1;
            ismoving = true;
        }
        if (Input.GetKey(KeyCode.K) && direction1 == -1)
        {
            direction1 *= -1;
            ismoving = true;
        }
        if (Input.GetKey(KeyCode.None))
            ismoving = false;

    }

    Vector2 currentMovementTarget()
    {
        if (direction == 1)
            return start.position;
        else
            return end.position;
    }

    Vector2 currentMovementTarget1()
    {
        if (direction1 == 1)
            return start1.position;
        else
            return end1.position;
    }

    public void Rotate()
    {
        zRotation = ladder.transform.eulerAngles.z;

        if (Input.GetKey(KeyCode.W) && zRotation <= 80f)
        {
            ladder.transform.Rotate(0f, 0f, 10 * Time.deltaTime, Space.Self);
            box.transform.Rotate(0f, 0f, -10 * Time.deltaTime, Space.Self);
            ismoving = true;
        }
                
        if (Input.GetKey(KeyCode.S) && zRotation >= 5f)
        {
            ladder.transform.Rotate(0f, 0f, -10 * Time.deltaTime, Space.Self);
            box.transform.Rotate(0f, 0f, 10 * Time.deltaTime, Space.Self);
            ismoving = true;
        }
        if (Input.GetKey(KeyCode.None))
            ismoving = false;

    }
}
