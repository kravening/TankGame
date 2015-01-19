using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	public float lives = 10f;

	void Start () {
	
	}

	void Update () {

	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.name == "Bullet(Clone)")
		{
			lives--;

			if(lives <= 0)
			{
				Destroy(this.gameObject);
			}

		}

		if (coll.gameObject.name == "EnemyBullet(Clone)")
		{
			lives--;

			if(lives <= 0)
			{
				Destroy(this.gameObject);
			}

		}
	}
}
