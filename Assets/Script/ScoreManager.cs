using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Static variable to store the score
    public static int score = 0;

    // Method to add points to the score
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    // Method to retrieve the current score
    public static int GetCurrentScore()
    {
        return score;
    }
}
