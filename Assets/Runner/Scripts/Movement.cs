using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private SurfaceSlider _surfaceSlider;
    [SerializeField] private float _movementSpeed = 1.0f;
    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = _surfaceSlider.GetProjection(direction);
        Vector3 offset = directionAlongSurface * _movementSpeed * Time.deltaTime;
        if (offset.sqrMagnitude > 0.001)
            _target.transform.position += offset;
    }
    public void MakeVertical(Vector3 direction)
    {

        Quaternion targetRotation = _surfaceSlider.GetVerticalPosition(direction.normalized);
        _target.transform.rotation = targetRotation;
    }
}
