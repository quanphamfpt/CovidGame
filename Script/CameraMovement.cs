using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    private float time = 0f;
    private float interval = 20f;

    private void Start()
    {
        time = 0f;
        interval = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= interval && cameraSpeed <= 30)
        {
            Debug.Log(cameraSpeed);
            cameraSpeed += 5f;
            time = 0f;
            interval += 5f;
        }
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
