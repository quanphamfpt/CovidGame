using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] TMP_Text lifeTxt;
    [SerializeField] TMP_Text bulletTxt;
    [SerializeField] TMP_Text shieldTxt;

    public static UIManager Instance {  get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        shieldTxt.enabled = Player.Instance.invincible;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseLife()
    {
        lifeTxt.text = "Life: " + Player.Instance.life;
    }

    public void increaseBullet()
    {
        bulletTxt.text = "Bullet left: " + Player.Instance.bullet;
    }

    public void isInvincible()
    {
        shieldTxt.enabled = Player.Instance.invincible;
    }
}
