using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public float score;

    public static ScoreManager instance { get; private set; }

    private void Awake()
    {
        if(instance  == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("score"));
        scoreText.text = "Score: " + ((int)score).ToString() + "\nHigh Score: " + ((int)PlayerPrefs.GetFloat("score")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = "Score: " + ((int)score).ToString()+ "\nHigh Score: " + ((int)PlayerPrefs.GetFloat("score")).ToString();
        }
    }
}
