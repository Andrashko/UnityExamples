using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damage = 50f;

    void OnTriggerEnter(Collider other)
    {
        DamageActor damageActor = other.gameObject.GetComponent<DamageActor>();
        if (damageActor != null)
        {
            damageActor.TakeDamage(damage);
        }
    }
}
