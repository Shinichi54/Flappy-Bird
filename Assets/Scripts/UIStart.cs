using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIStart : MonoBehaviour {

	public GameObject Panel_Start;
	public GameObject Panel_Rate;
	public GameObject Panel_Rank;
	public GameObject Panel_Setting;
	public Text InputRadius;
	public Image Player;
	public Toggle _audio;
	public AudioSource bg;
	public Text score;
	public Text maxscore;

	void Awake()
	{
		_audio.isOn = GameSever.getSingleton ().isMute;
	}

	void Update()
	{
		GameSever.getSingleton ().isMute = _audio.isOn;
		bg.mute = GameSever.getSingleton ().isMute;
	}


	public void ExitClick()
	{
		Application.Quit ();
	}

	public void StartClick()
	{
		GameSever.getSingleton ().Reset ();
		SceneManager.LoadScene (1);
	}

	public void ClickOpenPanel_Rate()
	{
		if (!Panel_Rate.activeSelf)
		{
			Panel_Rate.SetActive(true);
		}
		if (Panel_Start.activeSelf)
		{
			Panel_Start.SetActive (false);
		}
	}

	public void ClickOpenPanel_Rank()
	{
		if (!Panel_Rank.activeSelf) 
		{
			Panel_Rank.SetActive(true);
		}
		if (Panel_Start.activeSelf) 
		{
			Panel_Start.SetActive (false);
		}
		score.text =  GameSever.getSingleton ().score.ToString();
		maxscore.text = GameSever.getSingleton ().maxscore.ToString();
	}

	public void ClickOpenPanel_Setting()
	{
		if (!Panel_Setting.activeSelf) 
		{
			Panel_Setting.SetActive(true);
		}
		if (Panel_Start.activeSelf) 
		{
			Panel_Start.SetActive (false);
		}
	}

	public void ClickClosePanel_Rate()
	{
		if (Panel_Rate.activeSelf) 
		{
			Panel_Rate.SetActive (false);
		}
		if (!Panel_Start.activeSelf) 
		{
			Panel_Start.SetActive (true);
		}
	}

	public void ClickClosePanel_Rank()
	{
		if (Panel_Rank.activeSelf) 
		{
			Panel_Rank.SetActive (false);
		}
		if (!Panel_Start.activeSelf) 
		{
			Panel_Start.SetActive (true);
		}
	}

	public void ClickClosePanel_Setting()
	{
		if (Panel_Setting.activeSelf) 
		{
			Panel_Setting.SetActive (false);
		}
		if (!Panel_Start.activeSelf) 
		{
			Panel_Start.SetActive (true);
		}
	}

	public void ClickOK()
	{
		GameSever.getSingleton ().PlayerRadius = int.Parse (InputRadius.text);
		Player.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (GameSever.getSingleton ().PlayerRadius * 2, GameSever.getSingleton ().PlayerRadius * 2);
	}
}
