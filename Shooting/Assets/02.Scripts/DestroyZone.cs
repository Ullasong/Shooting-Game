using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ε��� ��븦 �ı��ϰ�ʹ�.
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // other�� �ı��ϰ�ʹ�.
        Destroy(other.gameObject);
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
