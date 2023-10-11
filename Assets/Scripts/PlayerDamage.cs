using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    bool contusion;
    SpriteRenderer rend;
    float timer;
    
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (contusion)
        {
            timer += Time.deltaTime;

            if (timer >= 0.5f)
            {
                timer = 0;
                rend.enabled = true;
            }
            if (timer >= 0.25f)
            {
                rend.enabled = false;
            }

        }
        else
        {
            timer = 0;
            rend.enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" && !contusion && !PlayerLives.instance.dead)
        {
            PlayerLives.instance.lives -= 1;
            contusion = true;
            StartCoroutine(ContusionCoroutine());
        }
    }

    IEnumerator ContusionCoroutine()
    {
        yield return new WaitForSeconds(3f);
        contusion = false;
    }
}
