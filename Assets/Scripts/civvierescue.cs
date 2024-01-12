using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class civvierescue : MonoBehaviour
{
    public int civviescore = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "civillian") // Change "tag" to match your start point's tag.
        {
            Destroy(collision.gameObject);
            civviescore += 5;
        }
    }

    private void Update()
    {
       
    }
}
