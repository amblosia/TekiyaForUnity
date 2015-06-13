using System;
using System.Collections.Generic;

/// <summary>
/// 定数・static変数などの定義クラス。
/// </summary>
public static class ConstSettings
{
	/* シーン・GameObjectの名前 */
	/// <summary>TOP画面</summary>
	public const string TOP_SCENE_NAME = "top";
	/// <summary>ゲーム画面</summary>
	public const string GAME_SCENE_NAME = "play";
	/// <summary>ハイスコア表示画面</summary>
	public const string HISCORE_SCENE_NAME = "HiScore";
	/// <summary>ゲームオーバー画面</summary>
	public const string GAMEOVER_SCENE_NAME = "GameOver";
	
	/* タグ名 */
	public const string PLAYER_TAG_NAME = "Player";
	public const string PLAYER_BULLET_TAG_NAME = "PlayerBullet";
	public const string ENEMY_TAG_NAME = "Enemy";
	public const string ENEMY_BULLET_TAG_NAME = "EnemyBullet";
	/// <summary>ゲームオーバー画面</summary>
	public const string GAMEOVER_TAG_NAME = "GameOver";
	/// <summary>ハイスコア表示画面</summary>
	public const string HISCORE_TAG_NAME = "HiScore";
	
	
	/// <summary> 的のプレハブ </summary>
	public static readonly Dictionary<int, string> ENEMY_PREFABS_DICS =
		new Dictionary<int, string>(){
	};
}
