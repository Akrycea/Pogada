using UnityEngine;

public class FishAnimOff : MonoBehaviour
{
    private StateManager stateManager;
    void Start()
    {
        stateManager = GameObject.Find("StateManager").GetComponent<StateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!stateManager.zielony && !stateManager.szary)
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
