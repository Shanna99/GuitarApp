using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Networking;

public class ApiClient : MonoBehaviour
{
    private string backendUrl = "http://localhost:5000/note"; // replace with your backend URL

    public void PostNote(Note note)
    {
        StartCoroutine(PostNoteCoroutine(note));
    }

    private IEnumerator PostNoteCoroutine(Note note)
    {
        string json = JsonUtility.ToJson(note);
        UnityWebRequest request = new UnityWebRequest(backendUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(json);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Response: " + request.downloadHandler.text);
        }
        else
        {
            Debug.LogError("Error: " + request.error);
        }
    }
}