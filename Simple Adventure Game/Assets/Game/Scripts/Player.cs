using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);

    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRenderer;

	private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        float absVelocityX = Mathf.Abs(rigidbody2d.velocity.x);

        float forceX = 0f;
        float forceY = 0f;

        if (Input.GetKey("right"))
        {
            if (absVelocityX < maxVelocity.x)
            {
                forceX = speed;
            }
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("left"))   
        {
            if (absVelocityX < maxVelocity.x)
            {
                forceX = -speed;
            }
            spriteRenderer.flipX = true;
        }

        rigidbody2d.AddForce(new Vector2(forceX, forceY));

	}
}
