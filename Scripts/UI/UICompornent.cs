using System;

/// <summary>
/// UIの画面遷移まわりなどで使う、GameObjectの一時格納場所
/// （非アクティヴになるとGameObject.Find()で見つけられなくなるため、ここに格納しておく）
/// </summary>
[Serializable]
public class UICompornent
{
	// ゲームオーバーシーン
	private GameObject GameoverGO {get;}
	// ハイスコア表示シーン
	private GameObject HiscoreGO {get;}
	
	// インスタンス
	private static UICompornent instance = null;
	
	/// <summary>
	/// インスタンス呼び出し。インスタンスがない場合は初期化します。
	/// インスタンスを初期化したい場合は、必ず引数を両方とも設定してください。
	/// </summary>
	/// <param name="gameoverGO">ゲームオーバー画面のGameObject</param>
	/// <param name="hiscoreGO">ハイスコア表示画面のGameObject</param>
	/// <returns>UICompornentインスタンス</returns>
	public static UICompornent Get(GameObject gameoverGO = null, GameObject hiscoreGO = null) {
		if (instance == null && gameoverGO != null && hiscoreGO != null) {
			// 引数が設定されている場合のみ、インスタンス初期化。
			instance = new UICompornent(gameoverGO, hiscoreGO);
		}
		return instance;
	}
	
	/// <summary>
	/// コンストラクタ
	/// </summary>
	/// <param name="gameoverGO">ゲームオーバー画面のGameObject</param>
	/// <param name="hiscoreGO">ハイスコア表示画面のGameObject</param>
	private UICompornent(GameObject gameoverGO, GameObject hiscoreGO)
	{
		this.GameoverGO = gameoverGO;
		this.HiscoreGO = hiscoreGO;
	}
}
