using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpp_cameraController : MonoBehaviour
{
    public float rotSpeed = 2;
    public Transform target, player;
    float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {

    }
    private void LateUpdate()
    {
        CameraControl();
    }
    void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
