using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int maxHealth = 50;
    [SerializeField] private int currentHealth = 50;
    
    public void TakeDamage(int damage)
    {
        //currentHealth
    }

}
