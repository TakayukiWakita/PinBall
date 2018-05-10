using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HiScoreController : MonoBehaviour {

	// テキストオブジェクト
	private GameObject hiscoretext;

	// ハイスコア保存オブジェクト
	private GameObject hiscore;

	// Use this for initialization
	void Start () {
		// オブジェクト取得
		this.hiscore = GameObject.Find ("HiScore");
		this.hiscoretext = GameObject.Find ("HiScoreText");

		// ハイスコアの表示
		this.hiscoretext.GetComponent<Text>().text = "HiScore:" + hiscore.GetComponent<HiScoreManager> ().iHighScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		this.hiscore.GetComponent<HiScoreManager> ().setHighScore (0);
		this.hiscoretext.GetComponent<Text> ().text = "HiScore:0";
	}
}
