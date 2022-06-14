using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, DestroyObject
{
    [SerializeField] float bulletLife = 5f;
    float time;
    private void Update()
    {
        time += Time.deltaTime;
        if (time>bulletLife)
            Destroy(this.gameObject);
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyObject ds = collision.GetComponent<DestroyObject>();
        if(ds!= null)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }



}
