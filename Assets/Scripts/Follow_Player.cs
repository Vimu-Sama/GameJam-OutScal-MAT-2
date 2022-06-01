using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [SerializeField] float maximumDistance = 5f;
    [SerializeField] float moveSpeed = 1f ;
    [SerializeField] Transform player;
    void Update()
    {
        float x = Mathf.Pow(this.transform.position.x - player.position.x,2);
        float y = Mathf.Pow(player.position.y - this.transform.position.y, 2);
        if (Mathf.Sqrt(Mathf.Abs(x + y))> maximumDistance)
        {
            this.transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed);
        }
    }
}
