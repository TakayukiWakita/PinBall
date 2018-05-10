using UnityEngine;
using System.Collections;


public class HiScoreManager : MonoBehaviour {
	
	// ゲームオブジェクトのシングルトン化
	// シーンをまたいでもオブジェクトが保持される
	static public HiScoreManager instance;

	// ハイスコア保存用
	public int iHighScore;

	// ハイスコアの保存先キー
	private string key = "HighScore";

	// 多重インスタンス作成を防止
	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}

		// 保存していたハイスコアの取得（なければ初期値0）
		iHighScore = PlayerPrefs.GetInt(key,0);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setHighScore(int score){
		iHighScore = score;
		PlayerPrefs.SetInt (key, iHighScore);
	}
}
