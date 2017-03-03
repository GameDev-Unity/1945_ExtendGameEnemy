using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	private Text[] scores;
	private PlayerScript player1;
	private PlayerScript player2;

	// Use this for initialization
	void Start () {
		scores = GetComponentsInChildren<Text>();
		player1 = GameObject.Find ("Player1").GetComponent<PlayerScript> ();
		player2 = GameObject.Find ("Player2").GetComponent<PlayerScript> ();
		scores [0].text = "Player 1 Score: 0";
		scores [1].text = "Player 2 Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		scores [0].text = "Player 1 Score: " + player1.score;
		scores [1].text = "Player 2 Score: " + player2.score;
	}
}
