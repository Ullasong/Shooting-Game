using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ���ӿ��� UI�� �����ϰ�ʹ�.
// �����, ���� �Լ��� ���� �����ϰ�ʹ�.
// �¾ �� ���ӿ��� UI�� �����ʰ� �ϰ�ʹ�.
// �÷��̾ �״¼����� ���ӿ��� UI�� ���̰� �ϰ�ʹ�.
public class GameManager : MonoBehaviour
{
    // �̱������� �����ʹ�.
    public static GameManager instance = null;

    private void Awake()
    {
        instance = this;
    }

    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� ���ӿ��� UI�� �����ʰ� �ϰ�ʹ�.
        gameOverUI.SetActive(false);
        // ������Ʈ�� ������
        //BoxCollider col = gameObject.GetComponent<BoxCollider>();
        //col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ����� ��ư�� �������� ȣ��� �Լ�
    public void OnClickRestart()
    {
        print("OnClickRestart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // ���� ��ư�� �������� ȣ��� �Լ�
    public void OnClickQuit()
    {
        print("OnClickQuit");
        Application.Quit();
    }
}
