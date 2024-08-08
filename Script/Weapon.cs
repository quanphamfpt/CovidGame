using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && Player.Instance.bullet > 0)
        {
            SoundManager.instance.PlayeSFX(SoundManager.instance.shootSFX);
            Shoot();
            Player.Instance.bullet--;
            UIManager.Instance.increaseBullet();
        }

    }

    private void Shoot()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.transform.SetParent(firePoint);

    }
}
