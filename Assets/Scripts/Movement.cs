using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Physics Quantities")]
    [SerializeField] float moveSpeed;
    [HideInInspector] public bool controls = true;
    [HideInInspector] public bool move = true;
    
    [Header("Connected GameObjects")]

    bool jump = true;
    Vector2 pos = new Vector2(0, 0);


    private void Start()
    {
        controls = true;
        move = true;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + (pos.x * moveSpeed * Time.fixedDeltaTime),
                                transform.position.y + (pos.y * moveSpeed * Time.fixedDeltaTime));
        pos = new Vector2(0, 0);
    }
    void Update()
    {
        if (!move)
            Debug.Log("it worked!");
        if(move)
        {
            if(controls)
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
            else
            {
                if (Input.GetKey(KeyCode.D))
                {
                    pos = new Vector2(-1, 0);
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    pos = new Vector2(1, 0);
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    pos = new Vector2(0, 1);
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    pos = new Vector2(0, -1);
                }
            }
        }
        if(controls==false)
        {
            StartCoroutine(SetTrue("controls"));
        }
        if(move==false)
        {
            StartCoroutine(SetTrue("move"));
        }
    }
    IEnumerator SetTrue(string var)
    {
        yield return new WaitForSeconds(5);

        if (var == "controls")
            controls = true;
        else if (var == "move")
            move = true;
    }

}
