using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð����� �����忡�� ���� ����� �� ��ġ�� ������ ����ʹ�.
public class EnemyManager : MonoBehaviour
{
    // ����ð�
    float currentTime;
    // �����ð�
    public float createTime = 1;
    // �� ����
    public GameObject enemyFactory = null;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // 1. �ð��� �帣�ٰ�(����ð��� �����ϴٰ�)
        currentTime += Time.deltaTime;
        // 2. ���� ����ð��� �����ð��� �ʰ��ϸ�
        if (currentTime > createTime)
        {
            // ���� �������̶��
            // ���� �÷��̾ Scene�� �����Ѵٸ�
            //if (GameObject.Find("Player") != null)
            // ���� ���ӿ��� UI�� ��Ȱ��ȭ �Ǿ��ִٸ�
            if (false == GameManager.instance.gameOverUI.activeSelf)
            {
                // 3. �����忡�� ���� �����
                GameObject enemy = Instantiate(enemyFactory);
                // 4. �� ��ġ�� ������ ����ʹ�.
                // enemy��ġ = ����ġ
                enemy.transform.position = transform.position;
            }
            // 5. ����ð��� �ʱ�ȭ �ϰ�ʹ�.
            currentTime = 0;
        }
    }
}
