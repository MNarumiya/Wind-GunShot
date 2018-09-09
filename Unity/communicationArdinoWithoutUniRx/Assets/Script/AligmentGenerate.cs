using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AligmentGenerate : MonoBehaviour {

	public GameObject layzerBeem;
	// 弾丸発射点
    public Transform muzzle;
	private const KeyCode KEY = KeyCode.Space;

	private GameObject _layzerBeem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KEY)) {
    		 this._layzerBeem = Instantiate(layzerBeem) as GameObject;
			 this._layzerBeem.transform.position = muzzle.position;

			 // レーザーの向きを直す
			 Quaternion angle = Quaternion.Euler(0f, 0f, 180f);
			 this._layzerBeem.transform.rotation = this._layzerBeem.transform.rotation * angle;
		} 
		if (Input.GetKeyUp(KEY)) {
			Destroy(this._layzerBeem);
		}
	}
}
