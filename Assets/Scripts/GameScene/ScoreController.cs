using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	// テキストオブジェクト
	private GameObject scoretext;
	private GameObject hiscoretext;

	// ハイスコア保存オブジェクト
	private GameObject hiscore;

	// スコア計算用
	private int iScore;

	// ハイスコア保存用
	private int iHighScore;

	private bool bCollision = false;

	// Use this for initialization
	void Start () {
		// オブジェクト検索
		this.scoretext = GameObject.Find ("ScoreText");
		this.hiscoretext = GameObject.Find ("HiScoreText");
		this.hiscore = GameObject.Find ("HiScore");

		iScore = 0;

		// 保存していたハイスコアの取得
		iHighScore = hiscore.GetComponent<HiScoreManager> ().iHighScore;
		// ハイスコアの表示
		this.hiscoretext.GetComponent<Text>().text = "HiScore:" + iHighScore.ToString();
//		PlayerPrefs.SetInt (key, 0);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision other){

		iScore = int.Parse (this.scoretext.GetComponent<Text> ().text.Split(':')[1]);

		int iPoint = 0;

				// タグによって配点を変える
		if (tag == "SmallStarTag") {
			iPoint = 10;
		} else if (tag == "LargeStarTag") {
			iPoint = 50;
		} else if (tag == "SmallCloudTag" || tag == "LargeCloudTag") {
			iPoint = 100;
		}
		iScore += iPoint;
		bCollision = false;
			
		this.scoretext.GetComponent<Text>().text = "Score:" + iScore.ToString();

		// ハイスコア更新
		if(iScore>iHighScore){
			iHighScore = iScore;
			hiscore.GetComponent<HiScoreManager> ().setHighScore (iHighScore);
			this.hiscoretext.GetComponent<Text>().text = "HiScore:" + iHighScore.ToString();
		}



//		Debug.Log (iScore.ToString ());
	}
		
}
