
using UnityEngine;
/// <summary>
///  NPC 方法
/// </summary>
public class NPC : MonoBehaviour
{
    private void dialogue(string Talks = "對話內容")
    {
        print("對話內容 : ");
    }
    public bool OpenStore()
    {
        return true;
    }
    public int PurchaseProps()
    {
        print("道具價錢預設為 : " + 100);
        return 0;
    }
    public void GetTask()
    {
        print("任務編號 :");
    }
    private int TaskUpdate()
    {
        print("獲得道具數量預定為 :" + 1);
        return 0;
    }
    private bool FinishTask()
    {
        print("任務編號 : ");
        return false;
    }
    private void Start()
    {
        
    }
}
