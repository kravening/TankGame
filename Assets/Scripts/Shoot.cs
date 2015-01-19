using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject bulletPrefab;
	private GameObject turret;
	private GameObject nozzle;
	public float reloadTime = 0f;
	public float maxReloadTime = 0f;

	// Use this for initialization
	void Start () {

		Transform[] transforms = GetComponentsInChildren<Transform>();
		foreach(Transform t in transforms)
		{
			
			if(t.gameObject.name == "TurretBase")
			{
				turret = t.gameObject;
			}

			if(t.gameObject.name == "Nozzle")
			{
				nozzle = t.gameObject;
			}
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		float delta = Time.deltaTime;
		reloadTime += delta;

		Quaternion rotation = Quaternion.Euler(Vector3.up * turret.transform.rotation.eulerAngles.y);

		//mousebutton inplaats van fire1

		if (Input.GetMouseButtonDown(0))
		{
			if(reloadTime > maxReloadTime)
			{

			Instantiate(bulletPrefab, nozzle.transform.position, rotation);
			reloadTime = 0f;
			
			}
		}
	
	}
}
