using UnityEngine;
using System.Collections;

public class ThrowBall : MonoBehaviour
{

    public float throwSpeed = 10;
    float speed = 0;

    void Update()
    {
        speed = Mathf.Lerp(speed, 0, Time.deltaTime);
        transform.Translate(Vector3.forward * speed);
        if (Input.GetMouseButtonDown(0))
            speed = throwSpeed;
    }
}
