using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hose2 : MonoBehaviour
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
            projectile.transform.localRotation = spraypoint.localRotation;
            Vector3 dir = Quaternion.AngleAxis(spraypoint.rotation.eulerAngles.z, Vector3.forward)*Vector3.up;
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.AddForce(dir * power, ForceMode2D.Impulse);
            Destroy(projectile, 2f);
        }
    }
}
