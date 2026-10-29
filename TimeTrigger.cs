using UnityEngine;
using UnityEngine.Events;

public class TimeTrigger : MonoBehaviour
{
    // public string triggerTagName = "Timer";
    [Tooltip("The seconds to wait before the event happens")]
    public float duration = 10.0F;
    private float elapsedTime = 0.0F;

    [Tooltip("When the user starts the scene the event will either happen immediately or only after triggered")]
    public bool startOnAwake = false;
    [Tooltip("If you want the timer to restart and repeat the triggered event")]
    public bool repeat = false;

    [Tooltip("How many times the user wants the timer to reset and repeat its event")]
    public int repeatCount = 0;

    public UnityEvent onTimerComplete;

    public void StartTimer()
    {
        startOnAwake = true;
    }

    public void StopTimer()
    {
        startOnAwake = false;
    }

    public void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= duration) 
        {
            // when the timer completes invoke an event
            onTimerComplete.Invoke();
            elapsedTime = 0.0F;
            if (repeat)
            {
                if (repeatCount != 0)
                {
                    repeatCount -= 1;
                }
                else
                {
                    // nothing
                }
            }
            else
            {
                StopTimer();
            }
        }
        else
        {
            // during the counting
            // nothing
        }
    }

}