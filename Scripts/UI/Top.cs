using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲーム画面本体
/// </summary>
public class Top : MonoBehaviour {

	/// <summary>
	/// オブジェクト生成時
	/// </summary>
	void Start(){
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
	}
	
	/// <summary>
	/// スタートボタン
	/// </summary>
	void OnButtonStartClick(){
		UIUtil.NavigateStart();
	}

}
