using UnityEngine;

// Ensure this class name matches your filename "Isometric_Camera.cs"
public class Isometric_Camera : MonoBehaviour
{
    public Transform target; // Reference to the player
    private Vector3 offset; // The fixed distance from the player

    // Use this for initialization
    void Start()
    {
        // Calculate the initial offset based on the camera's starting position and the player's starting position.
        if (target != null)
        {
            offset = transform.position - target.position;
        }
    }

    // LateUpdate is called after all Update functions have completed
    void LateUpdate()
    {
        // Update the camera's position to be the target's position plus the fixed offset.
        if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
