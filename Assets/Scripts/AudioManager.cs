using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
	public enum AudioClipType
	{
		die,
		hit,
		point,
		wing
	}

	public static AudioManager _instance;

	public AudioClip[] allAudioClips;
	public AudioSource audioSourceBG;
	public AudioSource audioSourceOther;

	void Awake()
	{
		_instance = this;
	}

	public void SetAudio(AudioClipType index)
	{
		audioSourceOther.clip = allAudioClips[(int)index];
		audioSourceOther.Play ();
	}
}
