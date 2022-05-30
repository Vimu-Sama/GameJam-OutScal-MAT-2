using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletLife = 5f;
    float time;
    private void Update()
    {
        time += Time.deltaTime;
        if (time>bulletLife)
            Destroy(this.gameObject);
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bound")
        {
            Destroy(this.gameObject);
        }
    }

}
