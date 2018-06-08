using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

    public Debris debris;
    public int totalDebris = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Deadly")
        {
            OnExplode();
        }
    }

    void OnExplode()
    {
        Transform trans = transform;

        for (int i = 0; i < totalDebris; i++)
        {
            trans.TransformPoint(0, -100, 0);
            Debris clone = Instantiate(debris, trans.position, Quaternion.identity) as Debris;
            Rigidbody2D body2D = clone.GetComponent<Rigidbody2D>();
            body2D.AddForce(Vector3.right * Random.Range(-1000, 1000));
            body2D.AddForce(Vector3.up * Random.Range(500, 2000));
        }

        Destroy(gameObject);
    }
}
