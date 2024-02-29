using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTransform : MonoBehaviour
{
    private const float RatioSpeedChangeScale = 0.2f;
    private const float RatioSpeedRotate = 10f;

    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward, Space.Self);
        transform.Rotate(_speed * RatioSpeedRotate * Time.deltaTime * Vector3.up);
        transform.localScale += _speed * RatioSpeedChangeScale * Time.deltaTime * Vector3.one;
    }
}
