using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿����� �����¿��� ������ ����� �� �������� �̵��ϰ�ʹ�.
public class PlayerMove : MonoBehaviour
{
    // �ӷ�
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ������� �Է¿�����
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. �����¿��� ������ �����
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        //Vector3 dir = new Vector3(h, v, 0);
        dir.Normalize();
        // 3. �� �������� �̵��ϰ�ʹ�.
        // �̵����� P = P0 + vt  => P += vt
        transform.position += (dir * speed) * Time.deltaTime;
    }

}
