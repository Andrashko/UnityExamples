using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
    void Update()
    {
        Vector3 rotation = new Vector3(-Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0f);
        _target.Rotate(rotation);
    }
}
