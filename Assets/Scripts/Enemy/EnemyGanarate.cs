using UnityEngine;
using System.Collections;

public class EnemyGanarate : MonoBehaviour {
	
	/* プレハブに設定しておく値 */
	//敵の出現確率
	public float appearRange = 50f;
	//敵の移動スピード
	public float speed = 2f;
	//左へ動くか（左：true 右：false）
	public bool isLeftMove = true;

	/// <summary>
	/// フレームごとの処理
	/// （Enemy出現・移動処理）
	/// </summary>
	void Update () {
		const float appearRangeTotal = 100f;

		//敵出現の抽選
		float appear = Random.Range (1, appearRangeTotal);

		//抽選で当たった→敵出現
		if (appearRange <= appear){
			CreateEnemy();
		}
		//敵をこのオブジェクトごと移動させる。
		transform.Translate();
	}
	
	/// <summary>
	/// Enemy生成。
	/// </summary>
	void CreateEnemy(){
		//TODO: 敵の種類を抽選
		string enemyName;
		// Resourcesフォルダ内のプレハブから、抽選で当たったものを読み込み。
		GameObject enemyPrefub = (GameObject)Resources.Load ("Prefabs/" + enemyName);
		// Enemyオブジェクト作成
		GameObject enemy = (GameObject)Instantiate (enemyPrefub);
		// Enemyをこのオブジェクトの子にする（一斉に移動させるため）。
		enemy.transform.setParent (transform);
	}
}
