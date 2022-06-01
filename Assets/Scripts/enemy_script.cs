using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    private Transform player;
    
    public float speed= 100f;
    public float follow_dist=5f;
    public float min_dist=3f;
    private float time_var1;
    public float time_var2 = 2f;
    public ParticleSystem ps;
    int no_shots=2;

    public GameObject shot;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        time_var1 = time_var2;
    }

    void Update()
    {
        if (player != null)
        {
            float distance = Vector2.Distance(transform.position, player.position);
            
            if (distance > follow_dist)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            if (distance <= follow_dist && distance > min_dist)
            {
                transform.position = this.transform.position;
            }
            if (distance <= min_dist)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }

           



            if (time_var1 <= 0)
            {
                Instantiate(shot, transform.position, Quaternion.identity);  
                time_var1 = time_var2;
            }
            else
            {
                time_var1 -= Time.deltaTime;
            }

        }
    }


    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "shot_player")
        {
            if(no_shots<=0)
            {
                Instantiate(ps, transform.position, Quaternion.identity);
                Destroy(gameObject);
                no_shots = 2;
            }
            no_shots -= 1;
            
        }

    }


}

