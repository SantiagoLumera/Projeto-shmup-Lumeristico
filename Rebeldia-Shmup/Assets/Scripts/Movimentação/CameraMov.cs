using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = 2f;

    private void Start()
    {
        Cursor. lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        turn.y = Mathf.Clamp(turn.y, 0, 90f);
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
