using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour { 
	void OnTriggerEnter(Collider other){
 
        // もしもぶつかってきたオブジェクトのタグに「bullet」という名前がついていたら
        if(other.CompareTag("Bullet")){
 
            // ぶつかってきたオブジェクトを破壊（削除）せよ。
            Destroy(other.gameObject);
        }
    }
}
