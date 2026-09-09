using UnityEngine;

public class GroundTypeSFX : MonoBehaviour
{
    [SerializeField] private Footsteps footsteps;
    public bool rock;
    public bool grass;
    public bool cloud;

    void Start()
    {
    }

    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            ChangeGroundType();
        }
    }

    private void ChangeGroundType()
    {
        if (grass)
        {
            ChangeGroundToGrass();
        }
        else if (cloud)
        {
            ChangeGroundToCloud();
        }
        else if (rock)
        {
            ChangeGroundToRock();
        }
    }
    private void ChangeGroundToGrass()
    {
        footsteps.grass = true;
        footsteps.rock = false;
        footsteps.cloud = false;
    }
    private void ChangeGroundToRock()
    {
        footsteps.grass = false;
        footsteps.rock = true;
        footsteps.cloud = false;
    }
    private void ChangeGroundToCloud()
    {
        footsteps.grass = false;
        footsteps.rock = false;
        footsteps.cloud = true;
    }
}
