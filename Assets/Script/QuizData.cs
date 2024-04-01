using UnityEngine;

[CreateAssetMenu(fileName = "New Quiz Data", menuName = "Quiz System/Quiz Data")]
public class QuizData : ScriptableObject
{
    [System.Serializable]
    public class QuizQuestion
    {
        public string questionText;
        public string[] answerOptions;
        public int correctAnswerIndex;
    }

    public QuizQuestion[] questions;

    public void AddQuestion(string questionText, string[] answerOptions, int correctAnswerIndex)
    {
        QuizQuestion newQuestion = new QuizQuestion();
        newQuestion.questionText = questionText;
        newQuestion.answerOptions = answerOptions;
        newQuestion.correctAnswerIndex = correctAnswerIndex;

        // Resize the array and add the new question
        int newSize = questions != null ? questions.Length + 1 : 1;
        QuizQuestion[] newArray = new QuizQuestion[newSize];
        if (questions != null)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                newArray[i] = questions[i];
            }
        }
        newArray[newSize - 1] = newQuestion;
        questions = newArray;
    }
}
