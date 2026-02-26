using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

