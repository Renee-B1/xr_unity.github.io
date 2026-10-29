using UnityEngine;
using UnityEngine.Events;

public class SequenceAction : MonoBehaviour
{
    [Tooltip("The ordered events you want to occur one after another")]
    public UnityEvent[] steps;
    [Tooltip("The seconds to wait before each event happens")]
    public float[] stepDelays;

    private int curr_step = 0;
    private float elapsedTime = 0.0F;
    // private int missing = steps.Length - stepDelays.Length;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= stepDelays[curr_step])
        {
            steps[curr_step].Invoke();
            elapsedTime = 0.0F;
            curr_step++;
        }
        else
        {
            if (curr_step >= stepDelays.Length)
            {
                StopSequence();
            }
            Debug.Log(elapsedTime);
        }
    }

    public void StartSequence()
    {
        // If stepDelays is shorter than steps, treat the missing delays as 0. 
        // Calling StartSequence() while one is already running should restart it from the beginning.
        if (stepDelays.Length < steps.Length)
        {
            // Dr. Wang if you're reading this can i make it a list instead of an array
            // for (int i = stepDelays.Length; i < missing + steps.Length; i++)
            // {
            //     stepDelays[i] = 0f;
            // }
        }
    }

    public void StopSequence()
    {
        elapsedTime = 0.0F;
    }

}
