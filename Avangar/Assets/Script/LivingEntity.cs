using UnityEngine;
using System.Collections;

public class LivingEntity : MonoBehaviour, IDamageable
{

    public float startingHealth;
    public float health { get; protected set; }
    protected bool dead;

    public event System.Action OnDeath;
//vida
    protected virtual void Start()
    {
        health = startingHealth;
    }
//dano
    public virtual void TakeHit(float damage, Vector3 hitPoint, Vector3 hitDirection)
    {
        TakeDamage(damage);
    }
//checa o dano e ve se o personagem morre
    public virtual void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0 && !dead)
        {
            Die();
        }
    }
//destroy o inimigo morto
    [ContextMenu("Self Destruct")]
    public virtual void Die()
    {
        dead = true;
        if (OnDeath != null)
        {
            OnDeath();
        }
        GameObject.Destroy(gameObject);
    }
}
