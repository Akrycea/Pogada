using UnityEngine;
using Yarn.Unity;

public class CoreDebaty : MonoBehaviour
{
    public int YourPoints;
    public int EnemyPoints;



    [YarnCommand("Ending")]
    public void Ending()
    {
        if (YourPoints > EnemyPoints)
        {
            Debug.Log("you won yay");
        }

        if (EnemyPoints > EnemyPoints)
        {
            Debug.Log("you lost");
        }
    }


    //yarn commands, jest szansa ze to do wywalenia jest

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
