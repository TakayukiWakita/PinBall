using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	// スタートシーンに移行
	public void OnClick(){
		SceneManager.LoadScene ("GameScene");
	}
}
