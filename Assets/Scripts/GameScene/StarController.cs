using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {

	private float rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		this.gameObject.transform.Rotate (0, Random.Range (0, 360), 0);
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Rotate (0, this.rotSpeed, 0);
	
	}
}
