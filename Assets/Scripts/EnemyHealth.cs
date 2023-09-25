using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int curretHealth;
    [SerializeField] private GameObject enemy;
    [SerializeField] private Animator anim;

    void Start()
    {
        curretHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(int damage)
    {
        curretHealth = -damage;
        if(curretHealth <= 0)
        {
            Die();
        }
    }
    
   

    public void Die()
    {
        enemy.SetActive(false);
        Debug.Log("Enemy Eliminated");
    }
}
