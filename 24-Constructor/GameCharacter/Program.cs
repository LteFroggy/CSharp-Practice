using System;

// 기본 생성자
GameCharacter hero1 = new GameCharacter();
hero1.PrintStatus();

// 이름만 받는 생성자
GameCharacter hero2 = new GameCharacter("전사");
hero2.PrintStatus();

// 모든 값을 받는 생성자
GameCharacter hero3 = new GameCharacter("대마법사", 80, 25);
hero3.PrintStatus();