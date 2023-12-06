using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    private Quaternion CameraRotation;

    [Header("Camera Settings")]
    public float CameraSpeed;

    void Start()
    {
        CameraPosition = this.transform.position;
        CameraRotation = this.transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            CameraPosition.x -= CameraSpeed / 50;
        }
        if (Input.GetKey(KeyCode.S))
        {
            CameraPosition.x += CameraSpeed / 50;
        }
        if (Input.GetKey(KeyCode.A))
        {
            CameraRotation.y -= CameraSpeed / 150;
        }
        if (Input.GetKey(KeyCode.D))
        {
            CameraRotation.y += CameraSpeed / 150;
        }

        transform.SetPositionAndRotation(CameraPosition, CameraRotation);
    }
}
