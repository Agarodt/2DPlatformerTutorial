using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float timer = 3;

    void Start()
    {
        StartCoroutine(DestroyTime());
    }

    IEnumerator DestroyTime()
    {
        yield return new WaitForSeconds(timer);

        Destroy(gameObject);



    }
}
