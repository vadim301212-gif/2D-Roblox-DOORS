using UnityEngine;

public class RushSpawned : MonoBehaviour
{
    public GameObject Rush;
    
    public Animator animator;

    public string animName = "Rush";

    public GameObject DeathZone;

    public GameObject DeathZone2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Rush != null)
            {
                Rush.SetActive(true);
            }

            if (animator)
            {
                animator.SetTrigger(animName);
            }
        }
        if (collision.CompareTag("Rush"))
        {
            if (DeathZone != null)
            {
                DeathZone.SetActive(true);
            }
            if (DeathZone2 != null)
            {
                DeathZone2.SetActive(true);
            }
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
