using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using UnityEngine;
using TMPro; // Import the TextMeshPro namespace
using System.Collections;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeRemaining = 120f; // 2 minutes in seconds

    private bool isTimerRunning = false;

    void Start()
    {
        timerText.text = FormatTime(timeRemaining);
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (timeRemaining > 0 && isTimerRunning)
        {
            yield return new WaitForSeconds(1f);
            timeRemaining--;
            timerText.text = FormatTime(timeRemaining);
        }

        if (timeRemaining <= 0)
        {
            isTimerRunning = false; // Stop the timer if it's running
            Debug.Log("Time's up!");
            // Implement your game over logic here
        }
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // Optional method to stop the timer externally
    public void StopTimer()
    {
        isTimerRunning = false;
    }
}
