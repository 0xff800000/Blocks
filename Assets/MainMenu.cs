using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void playGame(){
		SceneManager.LoadScene("test walls");
	}

	public void quitGame(){
		Debug.Log ("Quit");
		Application.Quit();
	}
}
