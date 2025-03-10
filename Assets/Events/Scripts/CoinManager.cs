using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class CoinCollectedEvent : UnityEvent<int> { }
public class CoinManager : MonoBehaviour
{
    public static CoinCollectedEvent OnCoinCollected = new CoinCollectedEvent();

    public static int coinCount = 0;
    public static void IncCoinCount(int count)
    {
        coinCount += count;
    }

    void Start()
    {
        OnCoinCollected.AddListener(IncCoinCount);
    }
}


