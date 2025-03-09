using Unity.Mathematics;
using UnityEngine;

public class SurfaceSlider : MonoBehaviour
{
    private Vector3 _normal = Vector3.up;
    private Vector3 _lastMoveDirection;

    public Vector3 GetProjection(Vector3 moveDirection)
    {
        return moveDirection - Vector3.Dot(moveDirection, _normal) * _normal;
    }

    public quaternion GetVerticalPosition(Vector3 moveDirection)
    {
        if (moveDirection.sqrMagnitude > 0)
            _lastMoveDirection = moveDirection;
        Vector3 forwardDirection = GetProjection(_lastMoveDirection);
        return Quaternion.LookRotation(forwardDirection, _normal);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ground"))
            _normal = collision.contacts[0].normal;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Ground"))
            _normal = other.transform.up;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + _normal * 3);
    }
}
