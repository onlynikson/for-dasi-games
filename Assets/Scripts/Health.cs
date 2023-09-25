using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject restartScreen;
    

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        
    }

    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
        healthBar.SetHealth(currentHealth);
        

    }

    public void Die()
    {
        player.SetActive(false);
        restartScreen.SetActive(true);
        Debug.Log("Player Eliminated");
    }


    public void Restart()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("Game Restarted");
    }
        
        
        
        
        



    
}
