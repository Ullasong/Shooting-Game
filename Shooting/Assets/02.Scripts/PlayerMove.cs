using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자의 입력에따라 상하좌우의 방향을 만들고 그 방향으로 이동하고싶다.
public class PlayerMove : MonoBehaviour
{
    // 속력
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 사용자의 입력에따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 상하좌우의 방향을 만들고
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        //Vector3 dir = new Vector3(h, v, 0);
        dir.Normalize();
        // 3. 그 방향으로 이동하고싶다.
        // 이동공식 P = P0 + vt  => P += vt
        transform.position += (dir * speed) * Time.deltaTime;
    }

}
