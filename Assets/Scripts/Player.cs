﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 1f;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveH, moveV);
		rb2d.AddForce (movement * speed);
	}
}
