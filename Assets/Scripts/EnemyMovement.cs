using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 2;
   
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(target.position.x, transform.position.y), Time.deltaTime * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "PlayerBullet")
        {
            Destroy(gameObject,0.5f);
            Destroy(other.gameObject);
        }
    }

    void OnDestroy()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
