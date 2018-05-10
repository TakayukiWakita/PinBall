using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class RestartButtonController : MonoBehaviour {

//	private string gameSceneName = "GameScene";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		// 現在のシーンをリロード
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
//		Debug.Log ("リロード");
	}
}
