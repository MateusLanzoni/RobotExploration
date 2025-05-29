using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private bool usingCamera1 = true;

    public void SwitchCamera()
    {
        usingCamera1 = !usingCamera1;
        camera1.gameObject.SetActive(usingCamera1);
        camera2.gameObject.SetActive(!usingCamera1);
    }
}
