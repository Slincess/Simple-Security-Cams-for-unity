using UnityEngine;


public class SecurityCamButton : MonoBehaviour
{
    [SerializeField] private Camera Cam;

    public void OnClicked()
    {
        SecurityCamManger.instance.ChangeCurrent_CamID(Cam);
    }
}
