using UnityEngine;

public class Playersitting : MonoBehaviour
{
    public Transform seatPoint;  // biến này sẽ chứa điểm ngồi trên ghế

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Sit();
        }
    }

    void Sit()
    {
        if (seatPoint != null)
        {
            transform.position = seatPoint.position;
            transform.rotation = seatPoint.rotation;
        }
    }
}