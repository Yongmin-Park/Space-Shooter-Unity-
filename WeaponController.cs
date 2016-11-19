using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	public GameObject shot;
	public Transform firePosition;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Fire", 1, 2);
	}

	void Fire () 
	{
		Instantiate (shot, firePosition.position, firePosition.rotation);
	}
}
