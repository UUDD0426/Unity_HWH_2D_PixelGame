using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    [Header("血條")]
    public Image bar;

    /// <summary>
    /// 輸入血量與血量最大值並更新血條
    /// </summary>
    /// <param name="hp">當前血量</param>
    /// <param name="hpBar">血量最大值</param>
    public void UpdateHpBar(float hp,float hpMax)
    {
        //血條.填滿數值=當前血量/血量最大值
        bar.fillAmount = hp / hpMax;
    }
}
