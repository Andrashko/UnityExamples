using UnityEngine;

public class GlobalEventUI : MonoBehaviour
{
    void OnEnable()
    {
        GlobalEventSystem.GetEvent("CoinCollected").AddListener(OnCoinCollected);
        GlobalEventSystem.GetEvent<int>("CoinCollectedWithAmount").AddListener(OnCoinCollectedWithAmount);
    }

    void OnDisable()
    {
        GlobalEventSystem.GetEvent("CoinCollected").RemoveListener(OnCoinCollected);
        GlobalEventSystem.GetEvent<int>("CoinCollectedWithAmount").RemoveListener(OnCoinCollectedWithAmount);
    }
    void OnCoinCollected()
    {
        Debug.Log("Coin is collected");
    }

    void OnCoinCollectedWithAmount(int amount)
    {
        Debug.Log($"{amount} coins are collected");
    }

}
