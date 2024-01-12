using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopFiretruck : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime * speed;
    }
}
