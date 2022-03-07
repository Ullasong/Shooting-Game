using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� �̹����� ���� ��ũ�� �ϰ�ʹ�.
public class BG : MonoBehaviour
{
    Material mat; // cache
    public float speed = 0.1f;
    void Start()
    {
        // Mesh Renderer�� ��������ʹ�.
        MeshRenderer ren = gameObject.GetComponent<MeshRenderer>();
        // �׳༮���� Material�� ��������ʹ�.
        mat = ren.material;
    }

    void Update()
    {
        // Material�� offset Y���� ������Ű��ʹ�.
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
