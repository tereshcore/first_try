using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public GameObject losePanel, timerPanel, winPanel;
    int i;
    public Text timersec;
    void Start()
    {
        losePanel.SetActive(false);
        timerPanel.SetActive(false);
        winPanel.SetActive(false);
        i = 60;
    }

    IEnumerator Time()
    {
        for (i = 60; i > 0; i--)
        {
            Debug.Log(i);
            timersec.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (i <=0)
        {
            StopCoroutine("Time");
            losePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "START")
        {
            StartCoroutine("Time");
            timerPanel.SetActive(true);
        }
        if (other.tag == "Finish")
        {
            StopCoroutine("Time");
            winPanel.SetActive(true);
        }
    }
}
