using UnityEngine;


public class Enemy : MonoBehaviour
{
    public int damage = 10;
    [SerializeField] private GameObject player;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }

        
    }

    

    
}