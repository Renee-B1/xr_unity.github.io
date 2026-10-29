using UnityEngine;
using UnityEngine.Events;

public class OnTriggerAction : MonoBehaviour
{
    [Tooltip("The tag assigned to the object which will trigger the event when it comes in contact")]
    public string triggerTagName = "MainCamera";
    [Tooltip("What event you want to happen when this object enters the area")]
    public UnityEvent onEnter;
    [Tooltip("What event you want to happen when this object exits the area")]
    public UnityEvent onExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTagName))
        {
            onEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(triggerTagName))
        {
            onExit.Invoke();
        }
    }
}