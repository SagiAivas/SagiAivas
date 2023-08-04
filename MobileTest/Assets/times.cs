using UnityEngine;

public class times : MonoBehaviour
{
    private bool isMoving = false;
    private float second = 0;
    int time = 60;
    void Update()
    {
        second += Time.deltaTime;
        while (second > time && isMoving == false)
        {
            transform.Rotate(0, 0, -3);
            isMoving = true;
            time += 60;
            break;
        }
        isMoving = false;
        Debug.Log(second);
    }
}