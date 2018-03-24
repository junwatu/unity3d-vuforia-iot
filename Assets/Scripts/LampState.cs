using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampState : MonoBehaviour {

    private GameObject gameObjectRing;
	private Material m_Material;

	public float speed = 50.0f;
	public Material change_Material;
	public Material default_Material;

	void Start() {
        m_Material = GetComponent<Renderer>().material;
	}
	
	void Update() {
		transform.Rotate(Vector3.back * Time.deltaTime * speed);
	}

	public void ChangeColorGold() {
		Debug.Log("Button is pressed!");
		gameObject.GetComponent<Renderer>().material = change_Material;
	}

	public void ChangeColorDark() {
		gameObject.GetComponent<Renderer>().material = default_Material;
	}
}
