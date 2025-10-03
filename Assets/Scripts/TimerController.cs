using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float currentTime;
    float startTime;
    float timerLength; // Timer length in seconds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = 0.0f;
        timerLength = 5.0f;
        currentTime = 0.0f;
        UpdateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < timerLength)
        {
            currentTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
        
        else
        {
            ResetTimer();
        }
    }

    public void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        int milliseconds = (int)(currentTime * 1000) % 1000;
        timerText.text = string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);
    }

    public void ResetTimer()
    {
        currentTime = startTime;
        UpdateTimerDisplay();
    }

}
