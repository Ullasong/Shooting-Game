using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간마다 적공장에서 적을 만들고 내 위치에 가져다 놓고싶다.
public class EnemyManager : MonoBehaviour
{
    // 현재시간
    float currentTime;
    // 생성시간
    public float createTime = 1;
    // 적 공장
    public GameObject enemyFactory = null;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 시간이 흐르다가(현재시간이 증가하다가)
        currentTime += Time.deltaTime;
        // 2. 만약 현재시간이 생성시간을 초과하면
        if (currentTime > createTime)
        {
            // 만약 게임중이라면
            // 만약 플레이어가 Scene에 존재한다면
            //if (GameObject.Find("Player") != null)
            // 만약 게임오버 UI가 비활성화 되어있다면
            if (false == GameManager.instance.gameOverUI.activeSelf)
            {
                // 3. 적공장에서 적을 만들고
                GameObject enemy = Instantiate(enemyFactory);
                // 4. 내 위치에 가져다 놓고싶다.
                // enemy위치 = 내위치
                enemy.transform.position = transform.position;
            }
            // 5. 현재시간을 초기화 하고싶다.
            currentTime = 0;
        }
    }
}
