using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 태어날때 30%확률로 플레이어방향, 나머지확률로 아래방향으로 방향을 정하고싶다.
// 살아가면서 그 방향으로 계속 이동하고싶다.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // 0~9까지 값중에 임의의 값 하나를 뽑아서 result변수에 담고싶다.
        int result = Random.Range(0, 10);
        // 만약 result가 3보다 작다면
        if (result < 3)
        {
            // 플레이어방향,
            GameObject player = GameObject.Find("Player");
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else // 그렇지않다면
        {
            // 아래방향으로 방향을 정하고싶다.
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 2. 그 방향으로 이동하고싶다.
        transform.position += dir * speed * Time.deltaTime;
    }

    // 폭발공장
    public GameObject explosionFactory;
    // 누군가와 부딪혔을때 호출된다.
    private void OnCollisionEnter(Collision collision)
    {
        // 점수를 1점 증가시키고싶다.
        ScoreManager.instance.Score++;

        // 1. 폭발공장에서 폭발을 만들고
        GameObject explosion = Instantiate(explosionFactory);
        // 2. 내 위치에 가져다 놓고싶다.
        // exp위치 = 내 위치
        explosion.transform.position = transform.position;
        // 3. 2초 후에 폭발을 제거하고싶다.
        Destroy(explosion, 2);

        // Player or Bullet
        // 만약 충돌한 상대방의 이름에 Player가 포함되어있다면
        if (collision.gameObject.name.Contains("Player"))
        {
            // 부딪힌 상대방(collision.gameObject)에게서 PlayerHP 컴포넌트를 가져와서
            PlayerHP php = collision.gameObject.GetComponent<PlayerHP>();
            // 플레이어의 체력을 1 감소하고싶다.
            php.HP--;
            // 만약 플레이어의 체력이 0 이하라면
            if (php.HP <= 0)
            {
                // 게임오버 UI를 보이게 하고싶다.
                GameManager.instance.gameOverUI.SetActive(true);
                // 너죽고
                Destroy(collision.gameObject);
            }
        }
        else    // Bullet
        {
            // 너죽고
            Destroy(collision.gameObject);
        }
        // 나죽자
        Destroy(gameObject);
    }
}
