using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    public string colliderTagName = "Collider"; 
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
