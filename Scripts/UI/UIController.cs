using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UIがらみのメソッド集
/// </summary>
public static class UIUtil : MonoBehaviour {
	
	/// <summary>
	/// ゲームオーバー処理
	/// </summary>
	/// <param name="score">最終スコア</param>
	public static void GameOver(float score){
		// ハイスコア登録
		IO.SetScore(score);
		// ゲームオーバー画面をオーバーレイ
		Application.LoadLevelAdditive("GameOver");
	}
}
