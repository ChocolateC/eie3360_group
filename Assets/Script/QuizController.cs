using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizController : MonoBehaviour
{
    public TMP_Text questionText; // Use TMP_Text for question text
    public Button[] answerButtons;
    public TMP_Text feedbackText; // Use TMP_Text for feedback text
    public TMP_Text timerText; // Use TMP_Text for timer text
    public QuizData quizData;
    private int currentQuestionIndex = 0;
    public float timerDuration = 120f;
    private float timer;
    private bool quizActive = false;
    private int score = 0;

    void Start()
    {
        timer = timerDuration;
        DisplayQuestion();
        quizActive = true;
    }

    void Update()
    {
        if (quizActive)
        {
            timer -= Time.deltaTime;
            timerText.text = Mathf.RoundToInt(timer).ToString();
            if (timer <= 0)
            {
                EndQuiz();
            }
        }
    }

    void DisplayQuestion()
    {
        if (currentQuestionIndex < quizData.questions.Length)
        {
            QuizData.QuizQuestion currentQuestion = quizData.questions[currentQuestionIndex];
            questionText.text = currentQuestion.questionText;
            for (int i = 0; i < answerButtons.Length; i++)
            {
                answerButtons[i].GetComponentInChildren<TMP_Text>().text = currentQuestion.answerOptions[i]; // Use TMP_Text for answer options
            }
        }
    }

    public void CheckAnswer(int selectedAnswerIndex)
    {
        if (quizData.questions[currentQuestionIndex].correctAnswerIndex == selectedAnswerIndex)
        {
            // Correct answer
            feedbackText.text = "Correct!";
            score += 10;
        }
        else
        {
            // Incorrect answer
            feedbackText.text = "Incorrect!";
        }

        // Move to the next question
        currentQuestionIndex++;
        if (currentQuestionIndex < quizData.questions.Length)
        {
            DisplayQuestion();
        }
        else
        {
            EndQuiz();
        }
    }

    void EndQuiz()
    {
        quizActive = false;
        if (score >= 100)
        {
            SceneManager.LoadScene("SuccessScene");
        }
        else
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
