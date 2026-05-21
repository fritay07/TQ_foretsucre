using UnityEngine;
using UnityEngine.InputSystem;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Rigidbody2D rb;
    private Collider2D myCollider;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector2 mouseWindowPos = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(new Vector3(mouseWindowPos.x, mouseWindowPos.y, Mathf.Abs(mainCamera.transform.position.z)));
        Vector2 mousePos2D = new Vector2(mouseWorldPos.x, mouseWorldPos.y);

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (myCollider == Physics2D.OverlapPoint(mousePos2D))
            {
                isDragging = true;
                if (rb != null)
                {
                    rb.gravityScale = 0;
                    rb.linearVelocity = Vector2.zero;
                }
            }
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame && isDragging)
        {
            isDragging = false;
            if (rb != null)
            {
                rb.gravityScale = 1;
            }
        }

        if (isDragging)
        {
            transform.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, 0f);
        }
    }
}