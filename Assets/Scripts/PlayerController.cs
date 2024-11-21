using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
