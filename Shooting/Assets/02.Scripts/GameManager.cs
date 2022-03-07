using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 게임오버 UI를 관리하고싶다.
// 재시작, 종료 함수를 만들어서 관리하고싶다.
// 태어날 때 게임오버 UI를 보지않게 하고싶다.
// 플레이어가 죽는순간에 게임오버 UI를 보이게 하고싶다.
public class GameManager : MonoBehaviour
{
    // 싱글톤으로 만들고싶다.
    public static GameManager instance = null;

    private void Awake()
    {
        instance = this;
    }

    public GameObject gameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        // 태어날 때 게임오버 UI를 보지않게 하고싶다.
        gameOverUI.SetActive(false);
        // 컴포넌트를 끌때는
        //BoxCollider col = gameObject.GetComponent<BoxCollider>();
        //col.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 재시작 버튼이 눌러지면 호출될 함수
    public void OnClickRestart()
    {
        print("OnClickRestart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // 종료 버튼이 눌러지면 호출될 함수
    public void OnClickQuit()
    {
        print("OnClickQuit");
        Application.Quit();
    }
}
