using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UIがらみのstaticメソッド集
/// </summary>
public static class UIUtil : MonoBehaviour {
	

	/// <summary>
	/// スタート画面に遷移
	/// </summary>
	public static void NavigateTop(){
		Application.LoadLevel(ConstSettings.TOP_SCENE_NAME);
	}

	/// <summary>
	/// ゲームスタート。
	/// </summary>
	public static void NavigateStart(){
		// オーバーレイするシーン設定を読み込み
		UICompornent inst = UICompornent.Get();
		if (inst != null){
			// あれば初期化しない設定にする
			DontDestroyOnLoad(inst.GameoverGO);
			DontDestroyOnLoad(inst.HiscoreGO);
		}
		// Playerデータ初期化
		SingletonCompornent<Player>.Clear();
		// ゲーム画面スタート
		Application.LoadLevel(ConstSettings.GAME_SCENE_NAME);
		
		// ゲーム画面以外の初期化処理
		if (inst == null){
			NavigateStartAfterTop();
		}
		//　ゲーム画面開始
		Time.timeScale = 1;
	}
	
	/// <summary>
	/// ゲーム画面に遷移
	/// </summary>
	public static void NavigateStartAfterTop(){
		// TOP以外の各画面呼び出し
		Application.LoadLevelAdditive(ConstSettings.GAMEOVER_SCENE_NAME);
		Application.LoadLevelAdditive(ConstSettings.HISCORE_SCENE_NAME);
		
		// TODO: 呼び出した各画面のGameObjectを取得
		GameObject hiscoreGO = GameObject.FindWithTag(ConstSettings.HISCORE_TAG_NAME);
		GameObject gameoverGO = GameObject.FindWithTag(ConstSettings.GAMEOVER_TAG_NAME);;
		
		// GameObjectを一時格納したうえで取得
		UICompornent compornent = UICompornent.Get(gameoverGO, hiscoreGO);
		// ハイスコア画面非アクティヴ
		hiscoreGO.SetActive(false);
		// ゲームオーバー画面非アクティヴ
		gameoverGO.SetActive(false);
	}

	/// <summary>
	/// ゲームオーバー処理
	/// </summary>
	/// <param name="score">最終スコア</param>
	public static void GameOver(float score){
		//　ゲーム画面一時停止
		Time.timeScale = 0;
		// ハイスコア登録
		IO.SetScore(score);
		// オーバーレイシーンを読み込み
		UICompornent compornent = UICompornent.Get();
		if (compornent == null) return;
		// ハイスコア画面
		GameObject hiscoreGO = compornent.HiscoreGO;
		// ゲームオーバー画面
		GameObject gameoverGO = compornent.GameoverGO;
		// アクティヴ制御
		NavigateNext(hiscoreGO, gameoverGO);
	}
	
	/// <summary>
	/// ハイスコア画面への遷移
	/// </summary>
	public static void NavigateHiScore(){
		// オーバーレイシーンを読み込み
		UICompornent compornent = UICompornent.Get();
		if (compornent == null) return;
		// ハイスコア画面
		GameObject hiscoreGO = compornent.HiscoreGO;
		// ゲームオーバー画面
		GameObject gameoverGO = compornent.GameoverGO;
		// アクティヴ制御
		NavigateNext(gameoverGO, hiscoreGO);
	}
	
	/// <summary>
	/// 画面遷移処理
	/// </summary>
	/// <param name="activeGO">現在の画面（非表示にしたい画面）</param>
	/// <param name="nextGO">遷移先画面</param>
	public static void NavigateNext(GameObject activeGO, GameObject nextGO){
		//　ゲーム画面一時停止
		Time.timeScale = 0;
		// 現在の画面非アクティヴ
		activeGO.SetActive(false);
		// 遷移先画面を有効にする
		nextGO.SetActive(true);
		
	}
	
	
}
