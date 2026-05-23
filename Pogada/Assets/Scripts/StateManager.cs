using UnityEngine;
using UnityEngine.Serialization;


public enum MyNewEnum 
{
    Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11
}


// recommended rename to GameProgressManager
public class StateManager : MonoBehaviour
{
    //Minigames won
    // this as an accessor, it can by red externally, but changed internally by NotifyCloudMinigameWon
    public bool CloudMinigameWon { get; private set; }
    public bool RiverMinigameWon;
    public bool BirdMinigameWon;
    public bool StatueMinigameWon;
    public bool FishMinigameWon;
    public bool OwlMinigameWon;
    public bool GlassMinigameWon;

    public MyNewEnum MyNewEnum = MyNewEnum.Value1;

    // this is a refactor recommendation
    public void NotifyCloudMinigameWon() 
    { 
        CloudMinigameWon = true;
        MyNewEnum = MyNewEnum.Value2;

        if (MyNewEnum == MyNewEnum.Value3) 
        { 
            // do something
        }
    }

    //Collected Stuff
    public bool BirdCollected;
    public int FishCollected; // needs to be x amount of fish
    public bool BlueprintCollected;
    public bool OwlCollected;
    public bool GlassCollected;

    //Debates won
    public bool Violaceus1DebateWon;
    public bool ViriDebateWon;
    public bool LivDebateWon;
    public bool RobertDebateWon;
    public bool LuteDebateWon;
    public bool LusDebateWon;
    public bool Violaceus2DebateWon;
    public bool AureusDebateWon;

        //tutaj lista kolorów które wróc¹
    public bool szary = false;
    public bool zielony = false;
    public bool czerwony = false;
    public bool granat = false;
    public bool pomarancz = false;
    public bool niebieski = false;
    public bool fiolet = false;
    public bool zolty = false;
}
