using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimNdShoot : MonoBehaviour
{
   public Camera cam;
   [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos; //bullets instantiating position
    [SerializeField] float bulletForce= 10f;
    Vector2 direction= new Vector2();
    [HideInInspector] public Vector2 bulletDirection= new Vector2();

   void Update()
   {
        Vector3 mousePos= Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        direction= new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y) ;
        transform.up = direction;
        if(Input.GetMouseButtonDown(0))  //if pressed left mouse key
        {
            GameObject instance =Instantiate(bullet, bulletPos.position, bulletPos.rotation);
            instance.GetComponent<Rigidbody2D>().AddForce(bulletPos.up * bulletForce, ForceMode2D.Impulse);
        }
   }
}
