using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경 이미지를 위로 스크롤 하고싶다.
public class BG : MonoBehaviour
{
    Material mat; // cache
    public float speed = 0.1f;
    void Start()
    {
        // Mesh Renderer를 가져오고싶다.
        MeshRenderer ren = gameObject.GetComponent<MeshRenderer>();
        // 그녀석에게 Material을 가져오고싶다.
        mat = ren.material;
    }

    void Update()
    {
        // Material의 offset Y값을 증가시키고싶다.
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
