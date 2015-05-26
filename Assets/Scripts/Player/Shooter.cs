using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

/**
 * Playerが操作する砲台 
 * （ライフなどは別箇所で管理）
 */
public class Shooter : MonoBehaviour, IPointerDownHandler {

	//bulletプレハブ
	public GameObject bulletPrefub;
	//bulletのスピード
	public float bulletSpeed = 2f;

	/**
	 * touchされたとき（EventSystems使用） 
	 */
	public void OnPointerDown(PointerEventData data){
	
		FireBullet (data.worldPosition);
	}

	/**
	 * bullet発射 
	 */
	void FireBullet(Vector3 position){

		GameObject bullet = (GameObject)Instantiate (bulletPrefub, position, Quaternion.identity);

		//TODO: sounds

		bullet.GetComponent<Rigidbody> ().AddForce (Vector3.up * bulletSpeed, ForceMode.Impulse);
	}
}
