using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAttack : MonoBehaviour
{
    public float attackRange;
    public Transform player;
    public GameObject Enemy1;
    public AudioClip jumpScare;
    public AudioSource audioSource;

    void Update()
    {
       RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange))
        {
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                audioSource.PlayOneShot(jumpScare, 1);
                Vector3 playerPosition = player.position;
                Enemy1.transform.position = playerPosition;
            }
        }
    }

}
