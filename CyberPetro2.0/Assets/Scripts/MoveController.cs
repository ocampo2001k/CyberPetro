using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public void Move(Vector2 direction)
    {
        transform.position += transform.forward * direction.x * Time.deltaTime +
            transform.right * direction.y * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
