using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);
    public float jetSpeed = 200f;
    public float airSpeedMultipleyer = .3f;
    public bool standing;
    public float standingThreshold = 4f;

    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController;

	private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update () {

        float absVelocityX = Mathf.Abs(rigidbody2d.velocity.x);
        float absVelocityY = Mathf.Abs(rigidbody2d.velocity.y);

        if (absVelocityY <= standingThreshold)
        {
            standing = true;
        }
        else
        {
            standing = false;
        }


        float forceX = 0f;
        float forceY = 0f;

        if (playerController.moving.x != 0)
        {
            if (absVelocityX < maxVelocity.x)
            {
                float newSpeed = speed * playerController.moving.x;
                forceX = standing ? newSpeed : (newSpeed * airSpeedMultipleyer);
                spriteRenderer.flipX = forceX < 0;
            }
        }
        
        if (playerController.moving.y != 0)
        {
            if (absVelocityY < maxVelocity.y)
            {
                forceY = jetSpeed * playerController.moving.y;
            }
        }

        rigidbody2d.AddForce(new Vector2(forceX, forceY));
	}
}
