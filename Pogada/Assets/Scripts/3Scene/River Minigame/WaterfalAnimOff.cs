using UnityEngine;

public class WaterfalAnimOff : MonoBehaviour
{
    private StateManager stateManager;
    void Start()
    {
        stateManager = GameObject.Find("StateManager").GetComponent<StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stateManager.szary && !stateManager.zielony && !stateManager.czerwony)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
