using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
	private float reloadTime = 0f;
	public float maxReloadTime = 5f;
	public GameObject bulletPrefab;

	private Transform turret;
	private Transform nozzle;

	// Use this for initialization
	void Start () {

		Transform[] transforms = this.gameObject.GetComponentsInChildren<Transform> ();
		foreach(Transform t in transforms)
		{
			if(t.gameObject.name == "TurretBase")
			{
				turret = t;
			}
			if(t.gameObject.name == "Nozzle")
			{
				nozzle = t;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		reloadTime += Time.deltaTime;

		if (reloadTime >= maxReloadTime) 
		{
			CheckForplayer();
		}

	}
	private void CheckForplayer()
	{
		Ray myRay = new Ray();

		myRay.origin = turret.position;
		myRay.direction = turret.forward;

		RaycastHit hitInfo;

		if(Physics.Raycast(myRay, out hitInfo, 50f))
		{
			string hitObjectName = hitInfo.collider.gameObject.name;

			if(hitObjectName == "PlayerTank")

			{
				Instantiate(bulletPrefab, nozzle.transform.position, nozzle.rotation);

				reloadTime = 0f;
			}

			
		}

	}
}
