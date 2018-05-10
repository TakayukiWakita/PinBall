using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	// ボールが見える再下位置
	private float visiblePosZ = -6.5f;

	// テキストオブジェクト
	private GameObject gameovertext;

	// ゲームオーバー時に有効になるボタンオブジェクト
	public GameObject restartButton;
	public GameObject returnButton;

	// Use this for initialization
	void Start () {
		this.gameovertext = GameObject.Find ("GameOverText");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ) {
			this.gameovertext.GetComponent<Text>().text = "Game Over";
			restartButton.SetActive (true);
			returnButton.SetActive (true);
		}
	}
}
