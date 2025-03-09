using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private SurfaceSlider _surfaceSlider;
    [SerializeField] private float _movementSpeed = 1.0f;
    [SerializeField] private float _minimalStep = 0.001f;

    // private void Start(){
    //     _target = transform;
    // }
    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = _surfaceSlider.GetProjection(direction);
        Vector3 offset = directionAlongSurface * _movementSpeed * Time.deltaTime;
        if (offset.sqrMagnitude > _minimalStep)
            _target.position += offset;
    }
    public void MakeVertical(Vector3 direction)
    {

        Quaternion targetRotation = _surfaceSlider.GetVerticalPosition(direction.normalized);
        _target.rotation = targetRotation;
    }
}
