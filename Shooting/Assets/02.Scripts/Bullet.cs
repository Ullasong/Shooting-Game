using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 위로 이동하고싶다.
public class Bullet : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 위방향을 만들고
        Vector3 dir = transform.up;
        // 2. 그 방향으로 이동하고싶다.
        transform.position += (dir * speed) * Time.deltaTime;
    }
}
