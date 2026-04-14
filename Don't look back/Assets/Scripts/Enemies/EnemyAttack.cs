using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange;
    public Transform player;
    public GameObject Enemy;
    public GameObject Enemy2;

    void Update()
    {
       RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange))
        {
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                Vector3 playerPosition = player.position;
                Enemy.transform.position = playerPosition;
            }
        }
    }
}
