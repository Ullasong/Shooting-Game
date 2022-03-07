using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �¾�� 30%Ȯ���� �÷��̾����, ������Ȯ���� �Ʒ��������� ������ ���ϰ�ʹ�.
// ��ư��鼭 �� �������� ��� �̵��ϰ�ʹ�.
public class Enemy : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // 0~9���� ���߿� ������ �� �ϳ��� �̾Ƽ� result������ ���ʹ�.
        int result = Random.Range(0, 10);
        // ���� result�� 3���� �۴ٸ�
        if (result < 3)
        {
            // �÷��̾����,
            GameObject player = GameObject.Find("Player");
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else // �׷����ʴٸ�
        {
            // �Ʒ��������� ������ ���ϰ�ʹ�.
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 2. �� �������� �̵��ϰ�ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }

    // ���߰���
    public GameObject explosionFactory;
    // �������� �ε������� ȣ��ȴ�.
    private void OnCollisionEnter(Collision collision)
    {
        // ������ 1�� ������Ű��ʹ�.
        ScoreManager.instance.Score++;

        // 1. ���߰��忡�� ������ �����
        GameObject explosion = Instantiate(explosionFactory);
        // 2. �� ��ġ�� ������ ����ʹ�.
        // exp��ġ = �� ��ġ
        explosion.transform.position = transform.position;
        // 3. 2�� �Ŀ� ������ �����ϰ�ʹ�.
        Destroy(explosion, 2);

        // Player or Bullet
        // ���� �浹�� ������ �̸��� Player�� ���ԵǾ��ִٸ�
        if (collision.gameObject.name.Contains("Player"))
        {
            // �ε��� ����(collision.gameObject)���Լ� PlayerHP ������Ʈ�� �����ͼ�
            PlayerHP php = collision.gameObject.GetComponent<PlayerHP>();
            // �÷��̾��� ü���� 1 �����ϰ�ʹ�.
            php.HP--;
            // ���� �÷��̾��� ü���� 0 ���϶��
            if (php.HP <= 0)
            {
                // ���ӿ��� UI�� ���̰� �ϰ�ʹ�.
                GameManager.instance.gameOverUI.SetActive(true);
                // ���װ�
                Destroy(collision.gameObject);
            }
        }
        else    // Bullet
        {
            // ���װ�
            Destroy(collision.gameObject);
        }
        // ������
        Destroy(gameObject);
    }
}
