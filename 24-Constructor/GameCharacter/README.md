# GameCharacter

게임 캐릭터를 나타내는 `GameCharacter` 클래스를 작성하시오. 생성자의 다양한 기능을 종합적으로 활용하시오.

**요구사항**

- 정적 읽기 전용 필드
  - `k_DefaultHealth`: 기본 체력 값 (100)
  - `k_DefaultAttack`: 기본 공격력 값 (10)

- 인스턴스 읽기 전용 필드
  - `_id`: 캐릭터 고유 ID (int) - 생성 순서대로 1, 2, 3... 자동 부여

- 인스턴스 필드
  - `_name`: 캐릭터 이름 (string)
  - `_health`: 현재 체력 (int)
  - `_attack`: 공격력 (int)

- 정적 필드
  - `_nextId`: 다음에 생성될 캐릭터의 ID (int)

- 정적 생성자
  - `_nextId`를 1로 초기화
  - "[시스템] GameCharacter 클래스 로드됨" 출력

- 인스턴스 생성자 (3개)
  - 기본 생성자: 이름을 "무명의 영웅"으로, 체력과 공격력은 기본값으로 초기화 (this() 사용)
  - 이름만 받는 생성자: 이름을 받고, 체력과 공격력은 기본값으로 초기화 (this() 사용)
  - 모든 값을 받는 생성자: 이름, 체력, 공격력을 모두 받아 초기화 (핵심 생성자)
  - 모든 생성자에서 ID 자동 부여 및 생성 메시지 출력

- 메서드
  - `PrintStatus()`: 캐릭터 상태를 출력

**테스트 코드**

```csharp
// 기본 생성자
GameCharacter hero1 = new GameCharacter();
hero1.PrintStatus();

// 이름만 받는 생성자
GameCharacter hero2 = new GameCharacter("전사");
hero2.PrintStatus();

// 모든 값을 받는 생성자
GameCharacter hero3 = new GameCharacter("대마법사", 80, 25);
hero3.PrintStatus();
```

## 예상 실행 결과

```
[시스템] GameCharacter 클래스 로드됨
[ID: 1] 캐릭터 '무명의 영웅' 생성됨
=== 캐릭터 #1: 무명의 영웅 ===
  체력: 100 / 공격력: 10
[ID: 2] 캐릭터 '전사' 생성됨
=== 캐릭터 #2: 전사 ===
  체력: 100 / 공격력: 10
[ID: 3] 캐릭터 '대마법사' 생성됨
=== 캐릭터 #3: 대마법사 ===
  체력: 80 / 공격력: 25
```
