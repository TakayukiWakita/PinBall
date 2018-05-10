using UnityEngine;
using System.Collections;

public class FripperTapCOntroller : MonoBehaviour {

	// HingiJointコンポーネント
	private HingeJoint myHingeJoint;

	private float defaultAngle = 20f;
	private float flickAngle = -20;


	// 左右タップ位置の判定
	private float leftOrRightPosX = 0.0f;


	// Use this for initialization
	void Start () {
		this.myHingeJoint = GetComponent<HingeJoint> ();

		SetAngle (this.defaultAngle);
	}

	// Update is called once per frame
	void Update () {

		// 左右フリッパーの状態
		bool isLeftFripperUp = false;
		bool isRightFripperUp = false;


		// タップ操作
		if (Input.touchCount > 0) {
			Touch[] myTuchese = Input.touches;

			foreach (Touch myTouch in myTuchese) {
				// タッチの状態をチェック
				// Ended:画面から指が離れたとき
				// Canceled:システムがタッチの追跡をキャンセルしたとき
				// Began:画面に指が触れたとき
				// Moved:画面上で指が動いたとき
				// Stationary:指が画面に触れているが動いていないとき
				if (myTouch.phase != TouchPhase.Ended && myTouch.phase != TouchPhase.Canceled) {
//					Debug.Log ("X:" + myTouch.position.x + " Y:" + myTouch.position.y);

					if (myTouch.position.x > leftOrRightPosX) {
						isRightFripperUp = true;
					} else {
						isLeftFripperUp = true;
					}
				}
					
			}
		}

		// フリッパーの状態フラグで角度を変化
		if(tag == "LeftFripperTag"){
			if(isLeftFripperUp){
				SetAngle (this.flickAngle);
			}else{
				SetAngle (this.defaultAngle);
			}
		} else if(tag == "RightFripperTag"){
			if(isRightFripperUp){
				SetAngle (this.flickAngle);
			}else{
				SetAngle (this.defaultAngle);
			}
		}
	}

	private void SetAngle(float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}
