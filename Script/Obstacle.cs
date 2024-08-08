using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {   
            if(!Player.Instance.invincible)
            {
                if (Player.Instance.life == 0)
                {
                    SoundManager.instance.PlayeSFX(SoundManager.instance.gameOverSfx);
                    SoundManager.instance.music.Stop(); 
                    Destroy(player.gameObject);
                }
                else
                {
                    Player.Instance.life -= 1;
                    UIManager.Instance.increaseLife();
                }
            }


        }
    }
}
