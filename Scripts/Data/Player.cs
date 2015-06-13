using System;

/// <summary>
/// Player関連の一時データ
/// </summary>
[Serializable]
public class Player
{
	// 現在のスコア
	private float score{get; set;}
	// ライフ
	private int life{get; set;}
	
	public Player(){
		score = 0;
		life = 3;
	}
}
