using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   public GameObject Bullet;
   public float bulletSpeed = 5;

    public void Shoot()
    {
        
        if (PlayerBullets.instance.bullets > 0)
        {
            GameObject Projectile = Instantiate(Bullet, transform.position, transform.rotation);

            Projectile.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);

            PlayerBullets.instance.bullets -= 1;
            
        }
    }
}
