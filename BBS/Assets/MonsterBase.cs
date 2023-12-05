using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Monster/Create new monster")]
public class MonsterBase : ScriptableObject
{
   [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite monSprite;

    [SerializeField] MonsterType type1;
    [SerializeField] MonsterType type2;

    [SerializeField] int maxHp;
    [SerializeField] int physical_Attack;
    [SerializeField] int physical_Defense;
    [SerializeField] int special_Attack;
    [SerializeField] int special_Defense;
    [SerializeField] int speed;
    
    [SerializeField] List<MovePool> movePool;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite MonSprite
    {
        get { return monSprite; }
    }
    public MonsterType Type1
    {
        get { return type1; }
    }
    public MonsterType Type2
    {
        get { return type1; }
    }
    public int MaxHp
    {
        get { return maxHp; }
    }
    public int PhysicalAttack
    {
        get { return physical_Attack; }
    }
    public int PhysicalDefense
    {
        get { return physical_Defense; }
    }
    public int SpecialAttack
    {
        get { return special_Attack; }
    }  
    public int SpecialDefense
    {
        get { return special_Defense; }
    }
    public int Speed
    {
        get { return speed; }
    }

    public List<MovePool> MovePools
    {
        get { return movePool; }
    }


    [System.Serializable]
    public class MovePool
    {
        [SerializeField] MoveBase moveBase;
        [SerializeField] int level;

        public MoveBase Base
        {
            get { return moveBase; }
        }

        public int Level
        {
            get { return level; }
        }
    }


}

public enum MonsterType
{
    None,
    Fire,
    Water,
    Grass,
    Earth,
    Air,
    Electric,
    Metal,
    Ice,
    

}
