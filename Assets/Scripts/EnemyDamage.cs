using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 10;
    [SerializeField] private GameObject enemy;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth health = collision.gameObject.GetComponent<EnemyHealth>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }


    }
}
