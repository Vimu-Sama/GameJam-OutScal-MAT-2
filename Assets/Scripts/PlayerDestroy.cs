using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour, DestroyObject, PowerUp
{
    void PowerUp.ChangeValues()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyObject destroyInstance = collision.gameObject.GetComponent<DestroyObject>();
        PowerUp powerInstance = collision.gameObject.GetComponent<PowerUp>();
        if (destroyInstance != null)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if(powerInstance!=null)
        {
            powerInstance.ChangeValues();
        }
    }

}
