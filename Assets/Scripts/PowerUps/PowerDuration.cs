using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDuration : MonoBehaviour
{
    [SerializeField] float duration = 40f;
    float currentTime = 0f;
    // Update is called once per frame
    void Update()
    {
        currentTime+= Time.deltaTime;
        if(currentTime>duration)
        {
            currentTime = 0f;
            Destroy(this.gameObject);
        }
    }
}
