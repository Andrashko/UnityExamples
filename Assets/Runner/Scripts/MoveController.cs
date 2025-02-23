using UnityEngine;
using UnityEngine.Animations;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Movement _movement;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(horizontal, 0, vertical);
        _movement.Move(offset);
        _movement.MakeVertical(offset);
    }
}
