using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class RoomsSpawn : MonoBehaviour
{
    public Direction direction;
    public enum Direction
    {
        Up,
        Right,
        Left,

    }

    private RoomsVariant variant;
    private int rand;
    private bool spawned = false;
    private float waitTime = 3f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        variant = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomsVariant>();
        
    }
     
    void Spawn()
    {
        if(!spawned)
        {
            if(direction == Direction.Up)
            {
                rand = Random.Range(0, variant.UpRoom.Length);
                Instantiate(variant.UpRoom[rand], transform.position, variant.UpRoom[rand].transform.rotation);
            }
        }
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
