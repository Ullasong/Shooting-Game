using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ü�°� ü�� UI�� �����ϰ�ʹ�.
// �¾ �� ü���� �ִ�ü������ �ϰ�ʹ�.
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
        // �¾ �� ü���� �ִ�ü������ �ϰ�ʹ�.
        sliderHP.maxValue = maxHP;
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
