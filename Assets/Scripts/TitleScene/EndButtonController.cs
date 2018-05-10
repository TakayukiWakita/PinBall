using UnityEngine;
using System.Collections;

public class EndButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// アプリケーション終了
	public void OnClick(){
		Debug.Log ("終了");
		Application.Quit ();
	}
}
