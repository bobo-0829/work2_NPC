
using UnityEngine;
/// <summary>
///  NPC ��k
/// </summary>
public class NPC : MonoBehaviour
{
    private void dialogue(string Talks = "��ܤ��e")
    {
        print("��ܤ��e : ");
    }
    public bool OpenStore()
    {
        return true;
    }
    public int PurchaseProps()
    {
        print("�D������w�]�� : " + 100);
        return 0;
    }
    public void GetTask()
    {
        print("���Ƚs�� :");
    }
    private int TaskUpdate()
    {
        print("��o�D��ƶq�w�w�� :" + 1);
        return 0;
    }
    private bool FinishTask()
    {
        print("���Ƚs�� : ");
        return false;
    }
    private void Start()
    {
        
    }
}
