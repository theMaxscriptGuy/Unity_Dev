using UnityEngine;
using System.Collections;

public class SetRotation : MonoBehaviour {
	public int angle = 30;
	public int speed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//for fixed rotation uncomment the line below:
		//Quaternion rot = Quaternion.Euler (0, angle, 0);

		//for animated cubemap:
		Quaternion rot = Quaternion.Euler (0, (Time.time * speed), 0);
		Matrix4x4 m = new Matrix4x4 ();
		m.SetTRS(Vector3.zero, rot,new Vector3(1,1,1) );
		renderer.material.SetMatrix ("_Rotation", m);
	}
}
