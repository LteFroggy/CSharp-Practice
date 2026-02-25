# 코딩 연습 - 함수 오버로드

`Program.cs`에 아래 과제들의 코드를 작성하세요.

> ⚠️ 함수 오버로드는 클래스 내부의 `static` 메서드에서만 사용 가능합니다. 최상위문의 로컬 함수에서는 사용할 수 없으므로 `class`와 `static void Main()`을 사용해야 합니다.
>
> 💡 과제마다 별도의 클래스(`class Program`, `class Calculator`)를 사용하므로, 한 과제를 작성하고 실행한 뒤 다음 과제로 교체하세요.

---

## 1. 매개변수 개수에 따른 오버로드

`class Program`에 `Greet()` 함수를 3가지로 오버로드하세요:

- `Greet()` - "안녕하세요." 출력
- `Greet(string name)` - "{name}님, 안녕하세요." 출력
- `Greet(string name, int times)` - "{name}님, 안녕하세요."를 times번 출력

`Main()`에서 `Greet()`, `Greet("홍길동")`, `Greet("김철수", 3)`을 호출하세요.

**실행 결과**

```
안녕하세요.
홍길동님, 안녕하세요.
김철수님, 안녕하세요.
김철수님, 안녕하세요.
김철수님, 안녕하세요.
```

---

## 2. 매개변수 타입에 따른 오버로드

`class Calculator`에 `Add` 함수를 3가지 타입으로 오버로드하세요:

- `Add(int a, int b)` - 정수 덧셈
- `Add(double a, double b)` - 실수 덧셈
- `Add(string a, string b)` - 문자열 연결

`Main()`에서 `Add(10, 20)`, `Add(3.1, 2.7)`, `Add("Hello, ", "World!")`를 호출하여 출력하세요.

**실행 결과**

```
30
5.8
Hello, World!
```
