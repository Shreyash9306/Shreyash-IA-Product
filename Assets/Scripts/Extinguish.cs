using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguish : MonoBehaviour
{
    public GameObject fire;
    public int fireScore = 0;
    public int firesdone = 0;

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fire")
        {
            Debug.Log("Collided with 'fire' object.");
            Destroy(collision.gameObject);
            fireScore += 5;
            firesdone += 1;
            Debug.Log(firesdone);
            
        }
        
    }

}
