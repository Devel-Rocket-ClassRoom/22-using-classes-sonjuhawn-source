using System;
using System.Collections.Generic;
using System.Text;

class GameCharacter
{
    public string Name { get; }
    public int Level => level;
    public int MaxHp => level * 100;
    public int CurrentHp => currenthp;
    public int AttackPower => level * 10;
    public bool IsAlive => CurrentHp > 0;

    public int level;
    public int currenthp;

    public GameCharacter(string name, int level)
    {
        Name = name;
        this.level = level;
        currenthp = MaxHp;
    }

    public void Attack(GameCharacter target)
    {
        target.TakeDamage(AttackPower);
        Console.WriteLine($"{Name}이(가) {target.Name}에게 {AttackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        if (CurrentHp - AttackPower > 0)
        {
            currenthp = CurrentHp - AttackPower;

        }
        else
        {
            currenthp = 0;
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHp}/500, 공격력: {AttackPower}");
    }
}