using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {

	// HingiJointコンポーネント
	private HingeJoint myHingeJoint;

	private float defaultAngle = 20f;
	private float flickAngle = -20;


	// Use this for initialization
	void Start () {
		this.myHingeJoint = GetComponent<HingeJoint> ();
	
		SetAngle (this.defaultAngle);
	}
	
	// Update is called once per frame
	void Update () {

		// 矢印キー操作
		// 矢印キーが入力された場合、対応するフリッパーを動かす
		if (Input.GetKeyDown (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		// 矢印キーが離された場合、対応するフリッパーを元に戻す
		if (Input.GetKeyUp (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.defaultAngle);
		}
		if (Input.GetKeyUp (KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.defaultAngle);
		}

	}

	private void SetAngle(float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}
