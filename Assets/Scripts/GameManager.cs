using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager {
	private static class GMLoader {
		public static readonly GameManager instance = new GameManager();
	}
	public static GameManager getInstance() {
		return GMLoader.instance;
	}

	public enum SceneList : byte{
		Loading = 0,
		Menu = 1,
		Level1 = 2
	}
	public SceneList active_scene;

	public enum MenuTypes : byte{
		MainMenu = 0,
		OptionsMenu = 1,
		PauseMenu = 2,
		GameOverMenu = 3
	}

	public readonly string[] MenuNames = new string[]{
		"Main Menu",
		"Options Menu",
		"Pause Menu",
		"Game Over Menu"
	};

	public MenuTypes ActiveMenu { get; set; }



}
