using UnityEngine;

public class PlayerPositionChange : MonoBehaviour
{
    public Vector3 desiredPosition;

    public Transform playerTransform;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerTransform.position = desiredPosition;
    }
}
