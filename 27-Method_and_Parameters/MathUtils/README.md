# MathUtils

다양한 수학 계산을 수행하는 유틸리티 메서드들을 식 본문 형식으로 작성하세요.

**요구사항**

다음 메서드를 모두 **식 본문 메서드** 형식(`=>`)으로 구현:

- `Square(int n)`: n의 제곱 반환
- `Cube(int n)`: n의 세제곱 반환
- `IsEven(int n)`: n이 짝수인지 여부 반환
- `IsPositive(int n)`: n이 양수인지 여부 반환
- `Abs(int n)`: n의 절댓값 반환
- `Clamp(int value, int min, int max)`: value를 min~max 범위로 제한한 값 반환

## 예상 실행 결과

```
5의 제곱: 25
3의 세제곱: 27
10은 짝수? True
-5는 양수? False
-7의 절댓값: 7
Clamp(15, 0, 10): 10
Clamp(-5, 0, 10): 0
Clamp(5, 0, 10): 5
```
