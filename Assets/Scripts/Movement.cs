using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Physics Quantities")]
    [SerializeField] float moveSpeed;
    [Header("Connected GameObjects")]

    bool jump = true;
    Vector2 pos = new Vector2(0, 0);

    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + (pos.x * moveSpeed * Time.fixedDeltaTime),
                                transform.position.y + (pos.y * moveSpeed * Time.fixedDeltaTime));
        pos = new Vector2(0, 0);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            pos = new Vector2(-1, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            pos = new Vector2(1, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            pos = new Vector2(0, 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pos = new Vector2(0, -1);
        }

    }
}
