using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{  
    public static PlayerBullets instance;
    public int bullets = 0;

    void OnEnable()
    {
        instance = this;
    }

    void Update()
    {
        
    }
}
