using UnityEngine;

public class Timer : MonoBehaviour
{
    private bool isMoving = false;
    private float second = 0;
    int time = 1;
    void Update()
    {
        second += Time.deltaTime;
        while (second > time && isMoving == false)
        {
            transform.Rotate(0, 0, -3);
            isMoving = true;
            time += 1;
            break;
        }
        isMoving = false;
        Debug.Log(second);
    }
}