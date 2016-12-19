using UnityEngine;
using System.Collections;

public class InitLevel : MonoBehaviour {
	public AudioClip soundtrack_level;

	// Use this for initialization
	void Awake(){
		Debug.Log("InitLevel chiamata");
		GameManager.getInstance().setMusic(soundtrack_level);
	}
}
