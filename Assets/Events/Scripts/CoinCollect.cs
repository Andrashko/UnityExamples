using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.OnCoinCollected.Invoke(1);
            Destroy(gameObject);
        }
    }
}
