using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnButtonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// タイトルシーンに移行
	public void OnClick(){
		SceneManager.LoadScene ("TitleScene");
	}
}
