using Unity.Mathematics;
using UnityEngine;


public class FrirtPersonControl : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float rotationSpeed = 200.0f;
    private Transform cameraTransform;

    [SerializeField] private float horizontalRotation = 0f;
    [SerializeField] private float verticalRotation = 0f;
    [SerializeField] private float rotationLimit = 45f;

    private Vector3 offset;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        offset = cameraTransform.position - transform.position;
    }
    void Update()
    {
        float rightTranslation = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float forwardTranslation = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Debug.DrawLine(transform.position, transform.position + transform.forward * 10f, Color.yellow);
        Vector3 translation = transform.forward * forwardTranslation + transform.right * rightTranslation;
        transform.Translate(translation);
        cameraTransform.position = transform.position + offset;

        horizontalRotation += Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed;
        verticalRotation += -Input.GetAxis("Mouse Y") * Time.deltaTime * rotationSpeed;
        verticalRotation = Mathf.Clamp(verticalRotation, -rotationLimit, rotationLimit);
        Quaternion cameraQuaternion = Quaternion.Euler(verticalRotation, horizontalRotation, 0f);
        cameraTransform.localRotation = cameraQuaternion;
        transform.localRotation = Quaternion.Euler(0, horizontalRotation, 0);
    }
}
