using UnityEngine;

public class DestroyRush : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float animLength= GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;

        Destroy(gameObject,animLength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
