using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲーム画面本体
/// </summary>
public class Play : MonoBehaviour {

	private Player player;
	
	/// <summary>
	/// オブジェクト生成時
	/// </summary>
	void Start(){
		// Playerデータ作成
		player = SingletonCompornent<Player>.Instance;
	}
	/// <summary>
	/// フレームごとの呼び出し
	/// </summary>
	void Update () {
	}
	
	/// <summary>
	/// GUI描画時
	/// </summary>
	void OnGUI(){
		//スコア表示
		GameObject scoreText = GameObject.Find("ScoreText");
		scoreText.GetCompornent<Text>().text = player.score;
		
		//TODO: ライフ表示
	}
	
	/// <summary>
	/// スタートボタン
	/// </summary>
	void OnButtonStartClick(){
		UIUtil.NavigateTop();
	}

}
