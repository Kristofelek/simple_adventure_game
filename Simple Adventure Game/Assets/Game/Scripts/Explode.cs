using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Deadly")
        {
            OnExplode();
        }
    }

    void OnExplode()
    {
        Destroy(gameObject);
    }
}
