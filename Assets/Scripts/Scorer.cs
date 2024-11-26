using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;

    private void OnCollisionEnter(Collision other)
    {
        hit++;
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log("You bumped: " + hit + " times");
    }
}
