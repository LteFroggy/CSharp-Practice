# 코딩 연습 - 문자열 다루기 (2)

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. 문자열 추출과 수정

### 1-1. Substring()

문자열 `"Hello, World!"`에서 `Substring(7)`로 7번 인덱스부터 끝까지, `Substring(0, 5)`로 처음 5글자를 각각 추출하여 출력하세요.

**실행 결과**

```
7번 이후: World!
처음 5글자: Hello
```

### 1-2. Replace()

문자열 `"Hello, World!"`에서 `Replace()`로 `"World"`를 `"C#"`으로 대체하여 출력하고, 메서드 체이닝으로 `"Hello"`를 `"안녕"`, `"World"`를 `"세계"`로 동시에 대체하여 출력하세요.

**실행 결과**

```
Hello, C#!
안녕, 세계!
```

### 1-3. Remove()

문자열 `"Hello, World!"`에서 `Remove(5, 7)`로 5번 인덱스부터 7글자를 삭제한 결과를 출력하세요.

**실행 결과**

```
Hello!
```

### 1-4. Insert()

문자열 `"Hello World"`에서 `Insert(5, ",")`로 5번 인덱스에 쉼표를 삽입한 결과를 출력하세요.

**실행 결과**

```
Hello, World
```

---

## 2. 문자열 분할과 결합

### 2-1. Split()

문자열 `"Red,Green,Blue"`를 `Split(',')` 메서드로 분할하고, `for` 반복문으로 인덱스와 함께 각 요소를 출력하세요.

**실행 결과**

```
0: Red
1: Green
2: Blue
```

### 2-2. 문자열과 문자 배열 변환

문자열 `"Hello"`를 `ToCharArray()`로 문자 배열로 변환하여 `foreach`로 출력하고, 다시 `new string(chars)`로 문자열로 변환하여 출력하세요.

**실행 결과**

```
문자 배열:
H e l l o
다시 문자열: Hello
```

---

## 3. 문자열 유효성 검사

### 3-1. IsNullOrEmpty()

`null`, 빈 문자열 `""`, 일반 문자열 `"Hello"`에 대해 `string.IsNullOrEmpty()`를 호출하여 결과를 출력하세요.

**실행 결과**

```
str1 검사: True
str2 검사: True
str3 검사: False
```

### 3-2. IsNullOrWhiteSpace()

빈 문자열 `""`, 공백만 있는 문자열 `"   "`, 일반 문자열 `"Hello"`에 대해 `string.IsNullOrWhiteSpace()`를 호출하여 결과를 출력하세요.

**실행 결과**

```
빈 문자열: True
공백만: True
텍스트: False
```

---

## 4. StringBuilder 클래스

### 4-1. 문자열 연결의 문제점

빈 문자열에 `for` 반복문(0~4)으로 `$"항목{i} "`을 `+=`로 연결하고 출력하세요.

**실행 결과**

```
항목0 항목1 항목2 항목3 항목4
```

### 4-2. StringBuilder 사용법

`StringBuilder` 객체를 생성하고 `Append()`로 `"January\n"`, `"February\n"`을 추가하고, `AppendLine()`으로 `"March"`를 추가한 후 `Console.Write()`로 출력하세요.

**실행 결과**

```
January
February
March
```

### 4-3. StringBuilder 주요 메서드

`StringBuilder`의 `Append()`, `AppendLine()`, `AppendFormat()`, `Insert()`, `Replace()` 메서드를 사용하여 문자열을 조합하고 출력하세요. `Append()`로 `"Hello"`, `" "`, `"World"`를 추가하고, `AppendLine("!")`으로 줄바꿈 추가, `AppendFormat("숫자: {0}", 123)`과 `AppendLine()`으로 숫자를 추가한 후, `Insert(0, ">>> ")`로 맨 앞에 삽입하고 `Replace("World", "C#")`으로 대체하세요.

**실행 결과**

```
>>> Hello C#!
숫자: 123
```

### 4-4. 메서드 체이닝

`new StringBuilder()`에 `Append()` 메서드를 체이닝하여 `"StringBuilder를 사용한 "`, `"메서드 "`, `"체이닝"`을 연결하고 `ToString()`으로 변환하여 출력하세요.

**실행 결과**

```
StringBuilder를 사용한 메서드 체이닝
```

