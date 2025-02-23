using UnityEngine;

public class FreeFall : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private void OnTriggerExit(Collider other)
    {
        _rigidbody.isKinematic = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _rigidbody.isKinematic = true;
    }
}
