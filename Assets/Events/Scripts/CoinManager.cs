using UnityEngine;
using UnityEngine.Events;

public class CoinManager : MonoBehaviour
{
    public static UnityEvent<int> OnCoinCollected = new UnityEvent<int>();

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
