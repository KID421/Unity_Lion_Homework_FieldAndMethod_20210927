using UnityEngine;

/// <summary>
/// NPC
/// �w�q NPC ��k
/// </summary>
public class NPC : MonoBehaviour
{
    /// <summary>
    /// ��ܥ\��
    /// </summary>
    /// <param name="dialogue">NPC �n������ܤ��e</param>
    private void Dialogue(string dialogue)
    {

    }

    /// <summary>
    /// ��s����
    /// </summary>
    /// <param name="propMission">���ȹD��ƶq</param>
    private int UpdateMission(int propMission = 1)
    {
        return 0;
    }

    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="indexMission">���Ƚs��</param>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    public bool OpenShop()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price">�D�����</param>
    public int BuyProp(int price = 100)
    {
        return 0;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="indexMission">���Ƚs��</param>
    public void GetMission(int indexMission)
    {

    }
}
