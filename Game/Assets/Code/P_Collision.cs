using UnityEngine;

public class P_Collision : MonoBehaviour
{
    public P_movement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle"){

		movement.enabled = false;
		FindObjectOfType<Game_Main>().GameOver();
		
}
    }
}