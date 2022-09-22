using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int healthPlayer;
    public Text scoreRes, healthInfo;
    int score;
    public GameObject losePanel2;

    // Start is called before the first frame update
    void Start()
    {
        healthPlayer = 10;
        score = 0;
        losePanel2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreRes.text = score.ToString();
        healthInfo.text = healthPlayer.ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            healthPlayer--;
        }
        if (other.tag == "Collect")
        {
            score++;

            Debug.Log(healthPlayer);
        }
        if (healthPlayer <= 0)
        {
            losePanel2.SetActive(true);
        }

    }
}
