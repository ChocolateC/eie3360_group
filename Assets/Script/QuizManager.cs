using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuizManager : MonoBehaviour
{
    public Text timerText;
    public int score = 0;
    public int targetScore = 100;
    public float timeRemaining = 120f; // 2 minutes in seconds

    private bool isQuizActive = false;

    void Start()
    {
        timerText.text = "Time: " + FormatTime(timeRemaining);
    }

    void Update()
    {
        if (isQuizActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerText.text = "Time: " + FormatTime(timeRemaining);
            }
            else
            {
                GameOver();
            }
        }
    }

    public void StartQuiz()
    {
        isQuizActive = true;
        StartCoroutine(Countdown());
    }

    public void CorrectAnswer()
    {
        score += 10;
        if (score >= targetScore)
        {
            Success();
        }
    }

    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1f);
            timeRemaining--;
        }

        GameOver();
    }

    void GameOver()
    {
        isQuizActive = false;
        Debug.Log("Game Over! Score: " + score);
        // Implement game over logic here (e.g., reset quiz, show game over UI)
    }

    void Success()
    {
        isQuizActive = false;
        Debug.Log("Success! Score: " + score);
        // Implement success logic here (e.g., exit quiz, go to next scene)
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
