using UnityEngine;
using System.Collections;
public class MyChara : MonoBehaviour {
	//キャラクターコントローラー
	private CharacterController cCon;
	//　キャラクターの速度
	private Vector3 velocity;
	private Animator animator;
	public float walkSpeed = 1f;
	void Start () {
		//キャラクターコントローラの取得
		cCon = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
	}
	void Update () {
		//　キャラクターコントローラのコライダが地面と接触してるかどうか
		if(cCon.isGrounded) {
			velocity = Vector3.zero;
			velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

			// if (velocity.magnitude > 0f) { // velocity.magnitudeでvelocityの長さを取得
			// 	animator.SetFloat("Speed", velocity.magnitude);
			// } else {
			// 	animator.SetFloat("Speed", 0f);
			// }
		}

		velocity.y += Physics.gravity.y * Time.deltaTime; //　重力値を計算
		cCon.Move(velocity * walkSpeed * Time.deltaTime); //　キャラクターコントローラのMoveを使ってキャラクターを移動させる
	}
}

