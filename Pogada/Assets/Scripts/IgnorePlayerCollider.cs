using UnityEngine;

public class IgnorePlayerCollider : MonoBehaviour
{
    [HideInInspector]
    public Transform player;
    [HideInInspector]
    public GameObject playerObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<Transform>();
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
