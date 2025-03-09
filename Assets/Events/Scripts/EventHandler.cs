using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public DamageActor damageActor;
    void Start()
    {
        damageActor.OnDamage += ShowDamage;
        damageActor.OnDeath += ShowDeath;
        CoinManager.OnCoinCollected.AddListener(ShowCoins);
    }

    void ShowCoins(int count)
    {
        Debug.Log($"Coins: {CoinManager.coinCount}");
    }

    void ShowDamage(float damage)
    {
        Debug.Log($"-{damage}, {damageActor.GetCurrentHealth()} HP");
    }

    void ShowDeath()
    {
        Debug.Log("You are dead");
    }
    void OnDestroy()
    {
        damageActor.OnDamage -= ShowDamage;
        damageActor.OnDeath -= ShowDeath;
        CoinManager.OnCoinCollected.RemoveListener(ShowCoins);
    }
}
