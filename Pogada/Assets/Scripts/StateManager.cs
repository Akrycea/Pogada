using UnityEngine;

public class StateManager : MonoBehaviour
{
    //Minigames won
    public bool CloudMinigameWon;
    public bool RiverMinigameWon;
    public bool BirdMinigameWon;
    public bool StatueMinigameWon;
    public bool FishMinigameWon;
    public bool OwlMinigameWon;
    public bool GlassMinigameWon;

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
