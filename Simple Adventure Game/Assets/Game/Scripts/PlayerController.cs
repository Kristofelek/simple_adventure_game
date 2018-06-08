using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector2 moving = new Vector2();

    private void Update()
    {
        moving = Vector2.zero;

        if (Input.GetKey("right"))
        {
            moving.x = 1;
        }
        else if (Input.GetKey("left"))
        {
            moving.x = -1;
        }

        if (Input.GetKey("up"))
        {
            moving.y = 1;
        }
        else if (Input.GetKey("down"))
        {
            moving.y = -1;
        }
    }


}