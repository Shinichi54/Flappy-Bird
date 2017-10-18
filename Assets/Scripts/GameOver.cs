using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public GameObject GameExit;

	public void ClickRestart()
	{
		GameSever.getSingleton ().Reset ();
		SceneManager.LoadScene (1);
	}

	public void ClickHome()
	{
		SceneManager.LoadScene (0);
	}

	public void Exit()
	{
		if (!GameExit.activeSelf) 
		{
			GameExit.SetActive (true);
		}
	}
	public void ClickYes()
	{
		Application.Quit ();
	}
	public void ClickNo()
	{
		if (GameExit.activeSelf) 
		{
			GameExit.SetActive (false);
		}
	}
}
