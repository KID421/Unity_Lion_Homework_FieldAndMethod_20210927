using UnityEngine;

/// <summary>
/// �Ǫ����O
/// �x�s�Ǫ����
/// </summary>
public class Monster : MonoBehaviour
{
    [Header("�򥻯�O"), Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [Range(0, 5000)]
    public float hp = 350;
    [Range(0, 50)]
    public float rangeTrack = 30;
    public Vector3 offsetTrack;
    [Header("�����D��")]
    public GameObject prop;
    [Range(0, 1)]
    public float probability = 1;
    [Header("���ĸ��")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
}
