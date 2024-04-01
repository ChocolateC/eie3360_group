using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine;

public class FeedbackTextManager : MonoBehaviour
{
    // Reference to the TextMeshPro Text component
    public TextMeshProUGUI feedbackText;

    void Start()
    {
        // Ensure the feedbackText variable is assigned
        if (feedbackText == null)
        {
            Debug.LogError("Feedback text component is not assigned!");
            return;
        }

        // Example: Set initial feedback text
        SetFeedbackText("Welcome! Press the button to start.");
    }

    // Method to update the feedback text dynamically
    public void SetFeedbackText(string text)
    {
        // Check if the feedbackText variable is assigned
        if (feedbackText == null)
        {
            Debug.LogError("Feedback text component is not assigned!");
            return;
        }

        // Update the text of the TextMeshPro Text component
        feedbackText.text = text;
    }
}
