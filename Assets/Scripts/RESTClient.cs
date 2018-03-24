using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RESTClient : MonoBehaviour
{
    public static string restUrl = "http://localhost:3003/api/lamp";
    public static IEnumerator LampState(string jsonString)
    {

        byte[] byteData = System.Text.Encoding.ASCII.GetBytes(jsonString.ToCharArray());

        UnityWebRequest unityWebRequest = new UnityWebRequest(restUrl, "POST");
        unityWebRequest.uploadHandler = new UploadHandlerRaw(byteData);
        unityWebRequest.SetRequestHeader("Content-Type", "application/json");

        yield return unityWebRequest.SendWebRequest();

        if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
        {
            Debug.Log("Error Request: "+ unityWebRequest.error);
        }

        else
        {
            Debug.Log("Response Code: " + unityWebRequest.responseCode);
        }
    }
}
