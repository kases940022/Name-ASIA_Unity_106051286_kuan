using UnityEngine;

public class Camera_ctroul : MonoBehaviour
{
    public Transform cam, target;
    public float speed;
    public Transform camtran;
    public float camspeed;

    private void Update()
    {
        Vector3 pos = Vector3.Lerp(cam.position, target.position, 0.5f * speed * Time.deltaTime);
        cam.position = pos;


    }
}
