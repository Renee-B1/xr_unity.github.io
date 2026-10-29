using UnityEngine;
using UnityEngine.Events;

public class TimeTrigger : MonoBehaviour
{
    // public GameObject objectToHide;
    // public string triggerTagName = "Timer";
    public float duration = 10.0F;
    private float elapsedTime = 0.0F;

    public bool startOnAwake = false;
    public bool repeat = false;

    [AddComponentMenu("0 means repeat forever")]
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