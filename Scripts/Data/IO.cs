using UnityEngine;
using System.Collections.Generic;

public static class IO : MonoBehaviour {

	private static readonly string[] hiScoreKeys = new string[]{
		"hiScore1","hiScore2","hiScore3","hiScore4","hiScore5"
	};
	
	/// <summary>
	/// ハイスコアをとってくる
	/// </summary>
	/// <returns>ハイスコア上位5つ</returns>
	public static List<float> GetHiScore(){
		List<float> hiScoreList = new List<float>();
		//Keyに基づいて、PlayerPrefsから値を取得。
		foreach (string key in hiScoreKeys){
			// スコア取得
			float score = PlayerPrefs.GetFloat(key, 0f);
			hiScoreList.Add(score);
		}
		//スコアの高い順に並び替え
		hiScoreList.Sort((a, b) => b - a);
		return hiScoreList;
	}
	
	/// <summary>
	/// 今あるハイスコアと比較し、スコアを登録。
	/// </summary>
	/// <param name="score">現在のスコア</param>
	/// <returns>更新あり：true 更新なし：false</returns>
	public static bool SetScore(float score){
		// 得点なし→更新なし
		if (score == 0) return false;
			
		// ハイスコア取得
		List<float>　scoreList = GetHiScore();

		// ハイスコアに載らない→更新なし
		if (scoreList.FindLast() > score) return false;
		
		// 現在のscoreを入れる
		scoreList.Add(score);
		// ハイスコア順に並び替え
		scoreList.Sort((a, b) => b - a);
		// 上位5つにする（6つになっているので、末尾を削る）
		scoreList.RemoveAt(scoreList.FindLastIndex());
		
		// PlayerPrefsに登録
		foreach (float s in scoreList){
			foreach (string key in hiScoreKeys){
				PlayerPrefs.SetFloat(key, s);
			}
		}
		// 更新ありで返す
		return true;
	}
}
