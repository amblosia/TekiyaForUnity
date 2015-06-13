using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

/// <summary>
/// ハイスコア表示画面
/// </summary>
public class HiScore : MonoBehaviour {

	private Player player;
	private List<float> scoreList;
	
	/// <summary>
	/// オブジェクト生成時
	/// </summary>
	void Start(){
		// Playerデータ
		player = SingletonCompornent<Player>.Instance;
	}
	
	void OnGUI(){
		// ハイスコア
		scoreList = IO.GetHiScore();
		// TODO: リスト作成
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
}
