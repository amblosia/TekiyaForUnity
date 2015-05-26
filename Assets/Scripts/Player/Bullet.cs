using UnityEngine;
using System.Collections;

/**
 * 自機のbullet
 */
public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//何も当たらなければ、タイマーでオブジェクトをなくす。 
		Destroy (gameObject, 3);
	
	}

	/**
	 * 何かにあたった時の処理（Collider使用） 
	 */
	void OnTriggerEnter(Collider other){
		// 自分自身も破壊
		Destroy (gameObject);
	}
}
