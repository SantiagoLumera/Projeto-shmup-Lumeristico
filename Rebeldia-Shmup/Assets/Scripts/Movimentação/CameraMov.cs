using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMov : MonoBehaviour
{
    public GameObject player;

    private Vector3 mousePos;

    public float speed = 5f;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        mousePos = Input.mousePosition;

        mousePos.z = 10f;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        mousePos.y = 0f;

        player.transform.position = Vector3.Lerp(player.transform.position, mousePos, Time.deltaTime * speed);
    }
}
