using UnityEngine;

public class LookRayCast : MonoBehaviour
{

    [SerializeField] private Transform target;
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            target.position = hit.point;
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

        }
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);
    }
}
