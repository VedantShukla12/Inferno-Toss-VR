using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabAndScore : MonoBehaviour
{
    // The player's score
    private int score = 0;

    // Reference to TextMeshPro UI element to display the score
    public TextMeshProUGUI scoreText;

    // Points awarded for grabbing and releasing the object
    public int points = 10;

    // Reference to XR Grab Interactable component
    private XRGrabInteractable grabInteractable;

    // Flag to check if the object is currently grabbed
    private bool isGrabbed = false;

    void Start()
    {
        // Initialize the score display at the start
        UpdateScoreText();

        // Get the XRGrabInteractable component on the object
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Add event listeners for grab and release actions
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    // Called when the object is grabbed
    void OnGrab(SelectEnterEventArgs args)
    {
        if (!isGrabbed)
        {
            isGrabbed = true;
            Debug.Log("Object grabbed!");
        }
    }

    // Called when the object is released
    void OnRelease(SelectExitEventArgs args)
    {
        if (isGrabbed)
        {
            Debug.Log("Object released!");

            // Increase the score when the object is released
            IncreaseScore(points);

            // Reset the grabbed flag
            isGrabbed = false;
        }
    }

    // Increase the player's score
    void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Update the TextMeshPro score display
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
