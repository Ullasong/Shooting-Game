using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 체력과 체력 UI를 관리하고싶다.
// 태어날 때 체력을 최대체력으로 하고싶다.
public class PlayerHP : MonoBehaviour
{
    public int maxHP = 10;
    int hp;
    public Slider sliderHP;

    public int HP
    {
        get { return hp; }
        set { 
            hp = value;
            sliderHP.value = hp;
        }
    }
    void Start()
    {
        // 태어날 때 체력을 최대체력으로 하고싶다.
        sliderHP.maxValue = maxHP;
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
