using UnityEngine;

public class LvlCompleted : MonoBehaviour
{
    
    public Game_Main gm;

    void OnTriggerEnter ()
    {
        
	gm.FinishedLevel();

    }
}
