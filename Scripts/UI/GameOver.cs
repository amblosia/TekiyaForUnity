using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲームオーバー画面
/// </summary>
public class GameOver : MonoBehaviour {

	private Player player;
	
	/// <summary>
	/// オブジェクト生成時
	/// </summary>
	void Start(){
		// Playerデータ作成
		player = SingletonCompornent<Player>.Instance;
	}
	
	void OnGUI(){
		//スコア表示
		GameObject scoreText = GameObject.Find("ScoreText");
		scoreText.GetCompornent<Text>().text = player.score;
	}

	/// <summary>
	/// スタートボタン
	/// </summary>
	void OnButtonStartClick(){
		UIUtil.NavigateStart();
	}
	
	/// <summary>
	/// TOPへボタン
	/// </summary>
	void OnButtonTopClick(){
		UIUtil.NavigateTop();
	}
	
	/// <summary>
	/// ハイスコア画面へ
	/// </summary>
	void OnButtonHiscoreClick(){
		UIUtil.NavigateHiScore();
	}
}
