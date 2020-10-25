using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Main : MonoBehaviour
{

    public GameObject lvlcompletedUI;

    public float TimeDelay = 0f;
 
    bool is_running = false;


    public void FinishedLevel(){

	lvlcompletedUI.SetActive(true);

}

    public void GameOver(){
	
	if (is_running == false){
	    is_running = true;
	    Debug.Log("Game over");
	    Invoke("NewGame", TimeDelay);
}
}
	
    void NewGame(){

	SceneManager.LoadScene("lvl1");


}
}
