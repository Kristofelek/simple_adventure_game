using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private Color startColor;
    private Color endColor;
    private float t = 0f;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startColor = spriteRenderer.color;
        endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        spriteRenderer.material.color = Color.Lerp(startColor, endColor, t / 2);

        if (spriteRenderer.material.color.a <= 0f)
        {
            Destroy(gameObject);
        }

    }
}
