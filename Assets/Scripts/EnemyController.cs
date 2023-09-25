using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] NavMeshAgent Enemy;
    [SerializeField] Transform Player;

 
    

    

    private void Update()
    {
        Enemy.SetDestination(Player.position);
        

        
    }



}
