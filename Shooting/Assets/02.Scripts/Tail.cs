using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������� ���ؼ� �̵��ϰ�ʹ�.
public class Tail : MonoBehaviour
{
    public GameObject target;
    public float speed = 5;

    void Update()
    {
        // 1. �������� ���ϴ� ������ �����
        // target - me
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();
        // 2. �� �������� �̵��ϰ�ʹ�.
        transform.position += (dir * speed) * Time.deltaTime;
    }
}
