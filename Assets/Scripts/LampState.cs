using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampState : MonoBehaviour
{

    private GameObject gameObjectLamp;
    private Material m_Material;
    public Material change_Material;
    public Material default_Material;

    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
    }

    public void ChangeColorON()
    {
        Debug.Log("Button is pressed!");
        gameObject.GetComponent<Renderer>().material = change_Material;

        string json = "{\"status\":\"true\"}";
        ChangeState(json);
    }

    public void ChangeColorOFF()
    {
        gameObject.GetComponent<Renderer>().material = default_Material;

        string json = "{\"status\":\"false\"}";
        ChangeState(json);
    }

    void ChangeState(string json)
    {
        StartCoroutine(RESTClient.LampState(json));
    }
}
