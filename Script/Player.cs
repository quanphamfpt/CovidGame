using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    public static Player Instance { get; private set; }
    public int life = 0;
    public int bullet = 0;
    public bool invincible = false;

    public float delay = 0f;
    float interval = 5f;

    private void Awake()
    {
        if(Instance == null)
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
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

        CheckInvicible();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    void CheckInvicible()
    { 
        if (Player.Instance.invincible)
        {
            delay += Time.deltaTime;
            if (delay >= interval)
            {
                invincible = false;
                UIManager.Instance.isInvincible();
                delay = 0f;
            }
        }
    }
}