using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    //註解
    //欄位語法
    //修飾詞 類型 名稱 (指定 值):
    //私人 private 不顯示  (預設值)
    //公開 public 顯示


    //類型 四大類型
    //整數 int
    //浮點數 flaot
    //布林值 bool teue是、false否
    //字串 string
    [Header ("等級")]
    public int LV = 1;
    [Range(0, 300)]
    public float speed = 10.5f;
    [Header ("角色是否死亡")]
    public bool isDead = false;
    [Tooltip("角色名稱")]
    public string cName = "安安";
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;

    //方法語法 Method-儲存複雜的程式區塊或演算法
    //修飾詞 類型 名稱 () {程式區塊或演算法 }
    //void 無類型
    
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        print("移動");
        float h = joystick.Horizontal;
        print("水平" + h);
        float v = joystick.Vertical;
        print("垂直" + v);
    }
    private void Attack()
    { 
    
    }
    private void Hit()
    { 
    
    }
 private void Dead()
    {

    }





}