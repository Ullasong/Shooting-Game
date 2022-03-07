using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� ���콺 ���ʹ�ư�� ������
// �Ѿ˰��忡�� �Ѿ��� ����� �ѱ���ġ�� ������ ����ʹ�.
public class PlayerFire : MonoBehaviour
{
    // �Ѿ˰���
    public GameObject bulletFactory;
    // �ѱ���ġ
    public Transform firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ���� ����ڰ� ���콺 ���ʹ�ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �Ѿ˰��忡�� �Ѿ��� ����� 
            GameObject bullet = Instantiate(bulletFactory);
            // 3. �ѱ���ġ�� ������ ����ʹ�.
            // �Ѿ�����ġ = �ѱ�����ġ
            bullet.transform.position = firePosition.position;
        }
    }
}
