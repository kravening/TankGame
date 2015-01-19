using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
	public float lifeTime = 0f;
	public float maxLifeTime = 8f;
	private Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity -= 0.1f;
		float delta = Time.deltaTime;
		lifeTime += delta;
		
		if(lifeTime > maxLifeTime)
		{
			Destroy(this.gameObject);
		}

	}
}
