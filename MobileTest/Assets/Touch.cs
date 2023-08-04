using UnityEngine;

public class Touch : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer.color = Color.white;
    }
    void Update()
    {
        if (Input.touches[0].phase == TouchPhase.Began)
        {
            spriteRenderer.color = Color.blue;
        }
        if (spriteRenderer.color == Color.blue && Input.touches[2].phase == TouchPhase.Began)
        {
            spriteRenderer.color = Color.red;
        }
    }
}
