using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManagerKeeper : MonoBehaviour {
	private GameManager GM;

	[SerializeField] private GameObject m_Player;
	[SerializeField] private GameObject m_Music;
	[SerializeField] private GameObject m_Sound;

	public AudioClip MusicSound,ClickSound;
	public Texture background,blackbg;

	void Awake(){
		DontDestroyOnLoad (gameObject);

		GM = GameManager.getInstance();

		GM.Player = this.m_Player;
		GM.Player.GetComponent<PlayerController>().canMoveCharacter = false;
		GM.Player.GetComponent<Rigidbody2D>().isKinematic = true;

		GM.MusicSound = this.MusicSound;
		GM.ClickSound = this.ClickSound;
		GM.background = this.background;
		GM.blackbg = this.blackbg;

		GM.m_MusicSource = this.m_Music.GetComponent<AudioSource> ();
		GM.m_SoundSource = this.m_Sound.GetComponent<AudioSource> ();


		GM.m_Settings.Load (GM.m_MusicSource, GM.m_SoundSource);

		GM.m_MusicSource.clip = GM.MusicSound;
		GM.m_MusicSource.Play ();



		GM.active_scene = SceneList.Menu;
		GM.ActiveMenu = MenuTypes.MainMenu;
	}

	void OnGUI(){
		GM.OnGUI();
	}

}
