using UnityEngine;

/**
 * 音の管理
 */
public class SoundManager {

	private AudioSource audioSR {get; set;}
	private AudioSource audioSESR {get; set;}
	
	/// <summary>
	/// BGMを流す
	/// </summary>
	/// <param name="clip">流すBGM</param>
	public void PlayBackSound(AudioClip clip){
		audioSR.clip = clip;
		audioSR.Play();
	}
	
	/// <summary>
	/// SEを鳴らす
	/// </summary>
	/// <param name="clip">鳴らすSE</param>
	public void PlaySESound(AudioClip clip){
		audioSESR.PlayOneShot(clip);
	}
	
}
