using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Col)
    {
        Debug.Log("Its working");
        if (Col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }


}

