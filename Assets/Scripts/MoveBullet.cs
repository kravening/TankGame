﻿using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {
	public float speed = 8f;
	public float lifeTime = 0f;
	public float maxLifeTime = 8f;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.deltaTime;
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
		lifeTime += delta;

		if(lifeTime > maxLifeTime)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter(Collision coll)
		{
			Instantiate (explosionPrefab, this.transform.position, this.transform.rotation);
			Destroy (this.gameObject);
		}
}
