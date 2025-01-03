using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SecurityCamManger : MonoBehaviour
{
    public static SecurityCamManger instance;
    [SerializeField] private List<Camera> SecurityCams = new List<Camera>();

    private void Start()
    {
        instance = this;
    }

    public void ChangeCurrent_CamID(Camera Cam)
    {
        if (SecurityCams.Contains(Cam) ==false )
        {
            SecurityCams.Add(Cam);   
        }
        if(SecurityCams.Count  != 0)
        {
            foreach (var i in SecurityCams)
            {
                i.gameObject.SetActive(false);
            }
        }
        Cam.gameObject.SetActive(true);
        Debug.Log($"CamChanged to ID {Cam.name}");
    }
}
