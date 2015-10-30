using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    void pauseGame()
    {
        Time.timeScale = (Time.time == 0.1f ? 2 : 0.1f);
    }

	public void LeaderBoard(GameObject goToLeaderboard){
		goToLeaderboard.SetActive (true);
	}

	public void ChangeToScene(int sceneToChangeTo){
		Application.LoadLevel (sceneToChangeTo);
	}
}