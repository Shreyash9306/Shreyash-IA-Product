using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTruck : MonoBehaviour
{
    public Rigidbody2D rearTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    private float movement;
    public bool locker = false;
    public bool ismoving;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (locker == false)
        {
            rearTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        }
         
    }

    public void Tire_Lock()
    {
        locker = true;
    }

    public void Tire_unLock()
    {
        locker = false;
    }
}
