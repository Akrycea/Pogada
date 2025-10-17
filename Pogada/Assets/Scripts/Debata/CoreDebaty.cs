using UnityEngine;
using Yarn.Unity;

public class CoreDebaty : MonoBehaviour
{
    //public int MaxPoints;
    public int YourPoints;
    public int EnemyPoints;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("GoodChoice")]
    public void GoodChoice()
    {
        YourPoints += 1; 
    }

    [YarnCommand("BadChoice")]
    public void BadChoice()
    {
        EnemyPoints += 1;
    }

    [YarnCommand("VGoodChoice")]
    public void VGoodChoice()
    {
        YourPoints += 2;
    }

    [YarnCommand("VBadChoice")]
    public void VBadChoice()
    {
        EnemyPoints += 2;
    }

    [YarnCommand("Ending")]
    public void Ending()
    {
        if(YourPoints > EnemyPoints)
        {
            Debug.Log("you won yay");
        }

        if (EnemyPoints > EnemyPoints)
        {
            Debug.Log("you lost");
        }
    }
}
