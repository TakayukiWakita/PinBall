﻿using UnityEngine;
using System.Collections;

public class BrightnessRegulator : MonoBehaviour {

	// マテリアルを取得
	Material myMaterial;

	private float minEmission = 0.3f;
	private float magEmission = 2.0f;

	private int degree = 0;
	private int speed = 10;

	Color defaultColor = Color.white;

	// Use this for initialization
	void Start () {
		// タグによって光らせる色を変える
		if (tag == "SmallStarTag") {
			this.defaultColor = Color.white;
		} else if (tag == "LargeStarTag") {
			this.defaultColor = Color.yellow;
		} else if (tag == "SmallCloudTag" || tag == "LargeCloudTag") {
			this.defaultColor = Color.cyan;
		}

		// オブジェクトからマテリアル取得
		this.myMaterial = GetComponent<Renderer>().material;

		// オブジェクトの最初の色を指定
		myMaterial.SetColor("_EmissionColor",this.defaultColor*minEmission);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.degree >= 0) {
			// 光らせる強度を計算する
			Color emissionColor = this.defaultColor * (this.minEmission +
			                      Mathf.Sin (this.degree * Mathf.Deg2Rad) * this.magEmission);

			// エミッションに色を設定する
			myMaterial.SetColor("_EmissionColor",emissionColor);

			this.degree -= this.speed;
		}
	}

	void OnCollisionEnter(Collision other){
		this.degree = 180;
	}
}
