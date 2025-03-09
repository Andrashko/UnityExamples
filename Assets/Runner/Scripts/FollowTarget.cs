using UnityEngine;

public class FollowTarget : MonoBehaviour
{

    private Vector3 _offset;
    [SerializeField] private Transform _target;
    void Start()
    {
        _offset = transform.position - _target.position;
    }

    void Update()
    {
        transform.position = _target.position + _offset;
       // transform.Translate(_offset);
    }
}
