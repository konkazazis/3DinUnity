using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        if (transform.position == playerPosition)
        {
            DestroyWhenReached();
        }
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    private void DestroyWhenReached()
    {
        Destroy(gameObject);
    }
}
