using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("商店介面")]
    public GameObject objShop;
    /// <summary>
    /// 玩家選取的武器
    /// 0 劍 2元
    /// 1 槌 2元
    /// 3 弓 2元
    /// </summary>
    public int indexWeapon;
    private int[] priceWeapon = { 2, 2, 2 };
    private float[] attackWeapon ={10, 50, 100};
    /// <summary>
    /// 玩家身上武器得物件 編號與選取物件相同
    /// </summary>
    public GameObject[] objWeapon;


    private Player player;
    private void Start()
    {
        player = GameObject.Find("人物").GetComponent<Player>();
    }
    /// <summary>
    /// 開啟商店介面
    /// </summary>
    public void OpenShop()
    {
        objShop.SetActive(true);
    }
    /// <summary>
    /// 關閉商店介面
    /// </summary>
    public void CloseShop()
    {
        objShop.SetActive(false);
    }
    /// <summary>
    /// 玩家選了哪個武器
    /// </summary>
    /// <param name="choose">武器編號</param>
    public void ChooseWeapon(int choose)
    {
        indexWeapon = choose;
    }
    /// <summary>
    /// 購買武器
    /// 判斷玩家金幣是否
    /// 購買後扣除金幣更新介面並顯示武器
    /// </summary>
    public void Buy()
    {
        if (player .coin >=priceWeapon [indexWeapon])
        {
            player.coin -= priceWeapon[indexWeapon];
            player .textCoin.text = "金幣:" + player .coin;
            player.attackWeapon = attackWeapon[indexWeapon];
            for(int i=0;i<objWeapon.Length; i++)
            {
                objWeapon[i].SetActive(false);
            }
            objWeapon[indexWeapon].SetActive(true);
        }
    }
}
