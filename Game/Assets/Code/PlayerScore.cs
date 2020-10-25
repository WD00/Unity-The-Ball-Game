using UnityEngine.UI;
using UnityEngine;


public class PlayerScore : MonoBehaviour
{
    
    public Transform player;
    public Text p_score;

    void Update()
    {
        p_score.text = player.position.z.ToString("0");
    }
}
