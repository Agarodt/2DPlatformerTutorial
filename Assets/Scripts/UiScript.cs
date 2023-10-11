using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    Image LivesImg;
    Text BulletsNum;
    [SerializeField]
    Sprite[] heartSpr;

    
    void Start()
    {
        LivesImg = transform.GetChild(0).GetComponent<Image>();
        BulletsNum = transform.GetChild(1).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       ChangeLivesImg();
       ChangeBulletsTxt();
        
    }

    void ChangeLivesImg()
    {
            switch(PlayerLives.instance.lives)
        {
            case 3:
            LivesImg.sprite = heartSpr[3];
            break;
            case 2:
            LivesImg.sprite = heartSpr[2];
            break;
            case 1:
            LivesImg.sprite = heartSpr[1];
            break;
            case 0:
            LivesImg.sprite = heartSpr[0];
            break;
        }
    }

    void ChangeBulletsTxt()
    {
        BulletsNum.text = "Bullets " + PlayerBullets.instance.bullets;
    }
}
