using UnityEngine;

public class UnitStats
{
    /// <summary> 機動力（移動速度） </summary>
    public int Mobility => _mobility;

    /// <summary> 近距離攻撃力 </summary>
    public int ShortRangeAttack => _shortRangeAttack;

    /// <summary> 遠距離攻撃力 </summary>
    public int LongRangeAttack => _longRangeAttack;

    /// <summary> HP </summary>
    public int MaxHP => _maxHP;

    public UnitStats(params UnitStatsData[] datas)
    {
        foreach (var data in datas)
        {
            _mobility += data.Mobility;
            _shortRangeAttack += data.ShortRangeAttack;
            _longRangeAttack += data.LongRangeAttack;
            _maxHP += data.MaxHP;
        }
    }

    private int _mobility;
    private int _shortRangeAttack;
    private int _longRangeAttack;
    private int _maxHP;
}
