using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
    
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
