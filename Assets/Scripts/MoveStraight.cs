using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    [SerializeField] private bool _isMove;

    private void Update()
    {
        if (_isMove)
        {
            transform.Translate(Time.deltaTime * Vector3.forward);
        }
    }
}
