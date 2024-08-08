using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Injection : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlayeSFX(SoundManager.instance.hitItemSFX);
            Player.Instance.bullet += 3;
            UIManager.Instance.increaseBullet();
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
