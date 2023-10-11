using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
    public static PlayerLives instance;

    public int lives = 3;
    public bool dead;

    void OnEnable()
    {
        instance = this;
    }

    void Update()
    {
        if (lives <= 0)
        {
            dead = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
