using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

	/* プレハブに設定しておく値 */
	//倒した時のスコア
	public float score = 100;
	//bulletを打てるか
	public bool canAttack = false;
	//bulletを打つ間隔
	public float shootDef = 2f;
	//bulletのスピード
	public float shootSpeed = 2f;
	//自分自身がbulletか
	public bool isBullet = false;

	// 発射タイマー用変数
	private float timerF = 0;

	/// <summary>
	/// フレームごとの呼び出し
	/// （bullet発射処理・タイマーでオブジェクト破棄）
	/// </summary>
	void Update () {
		if (canAttack){
			// Enemyオブジェクトを作成→bulletとして発射（あたり判定を付けるため）。
			// タイマー判定
			timerF += Time.deltaTime;
			if (shootDef < timerF) {
				// 初期化
				timerF = 0;
				// Resourcesフォルダ内のプレハブから、bulletを読み込み。
				GameObject bulletPrefub = (GameObject)Resources.Load ("Prefabs/EnemyBulletFrame");
				// オブジェクト作成
				GameObject bullet = (GameObject)Instantiate (bulletPrefub);
				// TODO: Particle＆SE
				// bullet発射
				bullet.GetComponent<Rigidbody> ().AddForce (Vector3.up * shootSpeed, ForceMode.Impulse);
			}	
		}

		//画面外に出たら、このオブジェクト自体を破棄。
		Destroy (gameObject, 5);
	}

	/// <summary>
	/// 何かにあたった時の処理（Collider使用）
	/// </summary>
	/// <param name="other">衝突を起こした相手方object</param>
	public void OnTriggerEnter(Collider other){
		
		// オブジェクトのタブごとに処理を分岐させる。
		switch (other.transform.tag){
			case "PlayerBullet":
				// 自機のbullet
				// スコア加算
				Player.score += score;
				//TODO: アニメーション＆SE＆perticle発生＆スコア表示

				// オブジェクト自体は破棄。
				Destroy(gameObject);
				break;
			case "Player":
				//自機
				if (isBullet){
					// TODO: SE＆Particle発生。
					
					// Playerのライフを1削る
					Player.life--;
					// オブジェクト自体は破棄。
					Destroy(gameObject);
					// ライフが0になったら
					if (Player.life == 0) {
						UIController.GameOver(Player.score);
					}
				}
				break;
			default:
				break;
		}
	}
}
