using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    [Tooltip("The tag assigned to the object which will trigger the event when it comes in contact")]
    public string colliderTagName = "Collider"; 
    [Tooltip("What event you want to happen when this object collides with another")]
    public UnityEvent onCollision;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(colliderTagName))
        {
            onCollision.Invoke();
            // Debug.Log("collided");
        }
    }
}
