using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hose : MonoBehaviour
{

    public GameObject hose;
    public GameObject water;

    public float power;

    public Transform spraypoint;

    void Update()
    {
        spray();
        
    }

    public void spray()
    {
        if (Input.GetKey("space"))
        {
            GameObject projectile = Instantiate(water, spraypoint.transform.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(spraypoint.right * power, ForceMode2D.Impulse);
            Destroy(projectile, 2f);
        }
    }
}
