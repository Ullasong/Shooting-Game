using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �̵��ϰ�ʹ�.
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
        // 1. �������� �����
        Vector3 dir = transform.up;
        // 2. �� �������� �̵��ϰ�ʹ�.
        transform.position += (dir * speed) * Time.deltaTime;
    }
}
