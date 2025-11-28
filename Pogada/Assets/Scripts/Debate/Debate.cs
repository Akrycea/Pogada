using UnityEngine;
using Yarn.Unity;

public class Debate : MonoBehaviour
{
    public int YourPoints;
    public int EnemyPoints;


    [YarnCommand("Ending")]
    public void Ending()
    {
        if (YourPoints > EnemyPoints)
        {
            Debug.Log("you won");
        }

        if (EnemyPoints > EnemyPoints)
        {
            Debug.Log("you lost");
        }
    }


    //debate yarn commands

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


    
}
