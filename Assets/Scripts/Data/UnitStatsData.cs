using UnityEngine;

[CreateAssetMenu(fileName = "UnitStatsData", menuName = "GameData/UnitStatsData")]
public class UnitStatsData : ScriptableObject
{
    /// <summary> 機動力（移動速度） </summary>
    public int Mobility => _mobility;

    /// <summary> 近距離攻撃力 </summary>
    public int ShortRangeAttack => _shortRangeAttack;

    /// <summary> 遠距離攻撃力 </summary>
    public int LongRangeAttack => _longRangeAttack;

    /// <summary> HP </summary>
    public int MaxHP => _maxHP;

    [SerializeField] private int _mobility = 100;
    [SerializeField] private int _shortRangeAttack = 200;
    [SerializeField] private int _longRangeAttack = 100;
    [SerializeField] private int _maxHP = 100;
}
