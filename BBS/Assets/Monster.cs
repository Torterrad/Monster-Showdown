using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    MonsterBase _base;
    int level;
    
    public Monster(MonsterBase mBase, int mLevel)
    {
        _base = mBase;
        level = mLevel;
    }

    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 10; }
    }

    public int Attack
    {
        get { return Mathf.FloorToInt((_base.PhysicalAttack * level) / 100f) + 5; }
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.PhysicalDefense * level) / 100f) + 5; }
    }
    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpecialAttack * level) / 100f) + 5; }
    }
    public int SpDefense
    {
        get { return Mathf.FloorToInt((_base.SpecialDefense * level) / 100f) + 5; }
    }
    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }


}
