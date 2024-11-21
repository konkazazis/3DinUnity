using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; 
    public float moveSpeed;
    public float followDistance;
    public Quaternion rotation;

    public void Update ()
    {
        Vector3 pos = Vector3.Lerp(transform.position, player.position + offset + -transform.forward * followDistance, moveSpeed * Time.deltaTime);
        transform.position = pos;

        transform.rotation = rotation;
    }
}
