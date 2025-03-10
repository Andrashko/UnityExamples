using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //unityEvent
            CoinManager.OnCoinCollected.Invoke(1);
            //GlobalEventSystem
            GlobalEventSystem.GetEvent("CoinCollected").Invoke();
            GlobalEventSystem.GetEvent<int>("CoinCollectedWithAmount").Invoke(1);
            // action
            Destroy(gameObject);
        }
    }
}
