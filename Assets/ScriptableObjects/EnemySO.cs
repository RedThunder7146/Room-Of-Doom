using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Scriptable Objects/EnemySO")]
public class EnemySO : ScriptableObject
{
    public string name;
    public int health;
    public int damMin;
    public int damMax;
    public float speed;
}
